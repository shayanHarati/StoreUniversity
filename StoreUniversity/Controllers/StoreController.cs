using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreUniversity.DTOs.Account;
using StoreUniversity.DTOs.Store;
using StoreUniversity.Services.CategoryServices;
using StoreUniversity.Services.ProductServices;
using StoreUniversity.Services.UserServices;
using StoreUniversityModels.Product;
using System.Reflection.Metadata.Ecma335;

namespace StoreUniversity.Controllers
{
    public class StoreController : Controller
    {
        
        private Iproduct product;
        private ICategory Category;
        private IUser user;
        public StoreController(Iproduct _product,ICategory _category,IUser _user)
        {
            product = _product;
            Category = _category;
            user = _user;
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
            List<string> images = new List<string>();
            foreach (var item in p.images)
            {
                images.Add(item.ImageName);
            }
            DetailsViewModel vm = new DetailsViewModel()
            {

                Price = p.Price,
                Id=p.Id,
                percent = off,
                ProductName = p.Name,
                product_Image = images ,
                Description=p.Description,
                tops= product.GetTopProducts()
            };
            return View(vm);
        }
        

    }
}
