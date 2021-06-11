using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Price_Comparison.Models;
using Price_Comparison.Repository;

namespace Price_Comparison.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static Dictionary<string, ProductModel> skuCache = new Dictionary<string, ProductModel>();
        private SAPService _sapService;
        private AmazonService _amazonrepository;
        private FlipkartService _flipkartService;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _amazonrepository = new AmazonService();
            _sapService = new SAPService();
            _flipkartService = new FlipkartService();
        }

        public IActionResult Index()
        {
            var products = GetAllProducts();
            return View();
        }

     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<ProductModel> GetAllProducts()
        {
           
            return null;
        }

        
    }
}
