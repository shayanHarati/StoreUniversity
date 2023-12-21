using Microsoft.AspNetCore.Mvc;
using StoreUniversity.Models;
using StoreUniversity.Services.ProductServices;
using StoreUniversityModels.Product;
using System.Diagnostics;

namespace StoreUniversity.Controllers
{
    public class HomeController : Controller
    {

        private Iproduct product;
        public HomeController(Iproduct _prod)
        {
            product = _prod;
        }
        [Route("/")]
        public IActionResult Index()
        {
            
            return View(product.GetTopProducts());
        }

        public IActionResult call()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
