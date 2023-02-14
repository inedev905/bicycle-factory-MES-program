using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2DTO;


namespace Team2.Util
{
    class CommonCodeUtil
    {
        public static void ComboBinding(ComboBox cbo, List<CommonCodeDTO> src
                                        , string category
                                        , bool blankItem = true, string blankText = "선택")
        {
            //var list = (from item in src
            //            where item.Category == category
            //            select item).ToList();

            //var list = src.Where<ComboItemDTO>((c) =>c.Category == category).ToList();

            var list = src.FindAll((c) => c.Category == category);

            if (blankItem)
            {
                CommonCodeDTO newItem = new CommonCodeDTO()
                {
                    Category = category,
                    Code = "",
                    Name = blankText
                };
                list.Insert(0, newItem);
            }

            cbo.DisplayMember = "Name";
            cbo.ValueMember = "Code";
            cbo.DataSource = list;
        }

        public static bool IsPhoneNumber(string input)
        {
            string phonePattern = @"\d{2,3}-\d{3,4}-\d{4}";
            if (!Regex.IsMatch(input, phonePattern))
                return false;
            else
                return true;
        }

        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (Bitmap)tc.ConvertFrom(data);
        }

        //image => byte[]
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter ic = new ImageConverter();
            return (byte[])ic.ConvertTo(img, typeof(byte[]));
        }
    }
}
