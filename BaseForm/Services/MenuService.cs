using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DTO;
using Team2DAO;

namespace Team2.Services
{
    class MenuService
    {
        public List<MenuDTO> GetUserMenu(string depCode, string titleCode)
        {
            MenuDAO db = new MenuDAO();
            List<MenuDTO> list = db.GetUserMenu(depCode, titleCode);
            db.Dispose();

            return list;
        }
    }
}
