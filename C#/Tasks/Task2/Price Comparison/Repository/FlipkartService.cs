using Price_Comparison.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Price_Comparison.Repository
{
    public class FlipkartService
    {
        private ProductRepository _productRepository;
        private Dictionary<string, ProductModel> product;
        public FlipkartService()
        {
            _productRepository = new ProductRepository();
        }
        public async Task<Dictionary<string, ProductModel>> GetAllProducts(List<string> skuList)
        {
            Dictionary<string, ProductModel> amazonSkus = new Dictionary<string, ProductModel>();
            var amazonSkuList = CheckSkuId(skuList);
            var allProducts = _productRepository.GetAllProducts();
            foreach (var skuId in amazonSkuList)
            {
                var temp = allProducts.Where(p => p.SkuId == skuId).FirstOrDefault();
                if (temp != null)
                {
                    amazonSkus.Add(skuId, temp);
                }
            }
            return amazonSkus;
        }

        private List<string> CheckSkuId(List<string> skuList)
        {
            var flipkartDb = DataSource();
            List<string> itemSkuList = new List<string>();
            foreach (var item in skuList)
            {
                if (flipkartDb.Contains(item)) { itemSkuList.Add(item); } ;
            }

            return itemSkuList;
        }

        private List<string> DataSource()
        {
            return new List<string>() { "105", "106" };
        }

    }
}
