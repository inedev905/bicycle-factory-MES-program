using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DAO;
using Team2DTO;

namespace Team2.Services
{
    public class ProductService
    {
        public List<ProductDTO> GetAllProduct()
        {
            ProductDAO db = new ProductDAO();
            List<ProductDTO> list = db.GetAllProduct();
            db.Dispose();

            return list;
        }

        /// <summary>
        /// 제품 카테고리별 공통 코드 가져오는 함수
        /// 카테고리 string 배열을 통해 배열에 포함된 모든 카테고리의 공통 코드를 가져옴
        /// 
        /// </summary>
        /// <param name="categories"></param>
        /// <returns></returns>
        public List<CommonCodeDTO> GetAllProductCommonCode(string[] categories)
        {
            CommonCodeDAO db = new CommonCodeDAO();
            List<CommonCodeDTO> list = db.GetCommonCategory(categories);
            db.Dispose();

            return list;
        }
        /// <summary>
        /// BOM List 전부 가져오는 메소드
        /// </summary>
        /// <param name="bomCategories"></param>
        /// <returns></returns>
        public List<BOMDTO> GetAllBom(string sp)
        {
            BomDAO db = new BomDAO();
            List<BOMDTO> list = db.GetAllBom(sp);
            db.Dispose();

            return list;
        }

        public List<materialListDTO> GetMaterialList()
        {
            BomDAO db = new BomDAO();
            List<materialListDTO> list = db.GetMaterialList();
            db.Dispose();

            return list;
        }

        public string CheckAllMaterials(MaterialCheckDTO materialCheck)
        {
            BomDAO db = new BomDAO();
            string result = db.CheckMaterial(materialCheck);
            db.Dispose();

            return result;
        }

        public string SetProduct(ProductDTO newProduct,MaterialCheckDTO newProductMaterials)
        {
            BomDAO db = new BomDAO();
            string result = db.SetProduct(newProduct, newProductMaterials);
            db.Dispose();

            return result;
        }

        public bool DelProduct(string txtItemID)
        {
            BomDAO db = new BomDAO();
            bool result = db.DelProduct(txtItemID);
            db.Dispose();

            return result;
        }

        public bool UpdateProductInfo(ProductDTO Product)
        {
            BomDAO db = new BomDAO();
            bool result = db.UpdateProductInfo(Product);
            db.Dispose();

            return result;
        }

    }
}
