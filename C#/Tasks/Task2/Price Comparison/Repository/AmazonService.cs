using Price_Comparison.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Price_Comparison.Repository
{
    public class AmazonService
    {
        public Dictionary<string, ProductModel> GetAllProducts(List<string> skuList)
        {
            return null;
        }

        private List<string> CheckSkuId(List<string> skuList)
        {
            var amazonDb = DataSource();
            List<string> itemSkuList = new List<string>();
            foreach (var item in skuList)
            {
                if (amazonDb.Contains(item)) { itemSkuList.Add(item); };
            }

            return itemSkuList;
        }

        private List<string> DataSource()
        {
            return new List<string>() { "001", "002" };
        }

    }
}
