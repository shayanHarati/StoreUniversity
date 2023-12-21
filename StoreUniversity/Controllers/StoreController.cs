using Microsoft.AspNetCore.Mvc;
using StoreUniversity.DTOs.Store;
using StoreUniversity.Services.ProductServices;
using StoreUniversityModels.Product;

namespace StoreUniversity.Controllers
{
    public class StoreController : Controller
    {
        
        private Iproduct product;
        public StoreController(Iproduct _product)
        {
            product = _product;
        }
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Details(int Id ,string cat)
        {
           
            var p=product.GetproductById(Id);
            var off = 0;
            if (p.Offcodes!=null)
            {
                 off= p.Offcodes.Max().Offcode.Percent;
            }
            ProductCartViewModel vm = new ProductCartViewModel()
            {
                Price = p.Price,
                percent =off,
                ProductName = p.Name,
                product_Image = p.Image
            };
            return View(vm);
        }

    }
}
