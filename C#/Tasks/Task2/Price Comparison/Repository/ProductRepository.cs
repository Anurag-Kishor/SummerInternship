using Price_Comparison.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Price_Comparison.Repository
{
    public class ProductRepository
    {
        public List<ProductModel> GetAllProducts()
        {
            return DataSource();
        }

        private List<ProductModel> DataSource()
        {
            return new List<ProductModel>() { 
                new ProductModel() { Name="Product1", SkuId="001", Stock=10, OwnPrice=500, AmazonCompetitors = null, FlipkartCompetitors = null }, 
                new ProductModel() { Name="Product2", SkuId="002", Stock=20, OwnPrice=1000, AmazonCompetitors = null, FlipkartCompetitors = null },
                new ProductModel() { Name="Product3", SkuId="003", Stock=30, OwnPrice=1500, AmazonCompetitors = null, FlipkartCompetitors = null },
                new ProductModel() { Name="Product4", SkuId="004", Stock=40, OwnPrice=2000, AmazonCompetitors = null, FlipkartCompetitors = null },
            };
        }
    }
}
