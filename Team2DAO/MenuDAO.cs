using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DTO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Team2DAO
{
    public class MenuDAO : IDisposable
    {
        SqlConnection conn;

        public MenuDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<MenuDTO> GetUserMenu(string depCode, string titleCode)
        {
            string sql = @"select menu_id, menu_name, menu_level, pnt_menu_id, program_name, menu_Img, menu_sort
                           from menu
                           where menu_id in (select menu_id from menuAuth where dep_code = @depCode and title_code = @titleCode)
                           union
                           select distinct P.menu_id, P.menu_name, P.menu_level, P.pnt_menu_id, P.program_name, P.menu_Img, P.menu_sort
                           from Menu P inner join Menu C on P.menu_id = C.pnt_menu_id
                           where C.menu_id in (select menu_id from menuAuth where dep_code = @depCode and title_code = @titleCode)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@depCode", depCode);
            cmd.Parameters.AddWithValue("@titleCode", titleCode);

            conn.Open();
            List<MenuDTO> list = Helper.DataReaderMapToList<MenuDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;

        }
    }

}
