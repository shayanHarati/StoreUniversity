using Microsoft.AspNetCore.Mvc;
using StoreUniversity.DTOs.Store;
using StoreUniversity.Services.CategoryServices;
using StoreUniversity.Services.ProductServices;
using StoreUniversityModels.Product;

namespace StoreUniversity.Controllers
{
    public class StoreController : Controller
    {
        
        private Iproduct product;
        private ICategory Category;
        public StoreController(Iproduct _product,ICategory _category)
        {
            product = _product;
            Category = _category;
        }
        public IActionResult Show(string _Category)
        {
            ShowViewModel vm = new ShowViewModel();
            
            
            vm.Products= product.GetAllProducts();
            vm.Categories = Category.GetAllCategories();
            if (_Category == null)
            {
                _Category = vm.Categories[0].Name;
            }
            vm.SelectedCategory = _Category;
            return View(vm);
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Details(int Id ,string cat)
        {
           
            var p=product.GetproductById(Id);
            int off = 0;
            if (p.Offcodes[0].Offcode != null)
            {
                off = p.Offcodes[0].Offcode.Percent;
            }

            if(p.Description == null)
            {
                p.Description = "";
            }
            DetailsViewModel vm = new DetailsViewModel()
            {
                Price = p.Price,
                percent = off,
                ProductName = p.Name,
                product_Image = p.Image,
                Description=p.Description,
            };
            return View(vm);
        }

    }
}
