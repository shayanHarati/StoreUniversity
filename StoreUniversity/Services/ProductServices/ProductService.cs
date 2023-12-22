using Microsoft.EntityFrameworkCore;
using StoreUniversity.Context.DataBase;
using StoreUniversity.DTOs.Store;
using StoreUniversityModels.Product;

namespace StoreUniversity.Services.ProductServices
{
    public class ProductService : Iproduct
    {
        private DB context;
        public ProductService(DB _context)
        {
            context = _context;
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.Include(c=>c.Category).ToList();
        }

        public Product GetproductById(int id)
        {
           return context.Products.Single(c => c.Id == id);
        }

        public List<StoreViewModel> GetTopProducts()
        {
            List<StoreViewModel> vm = new List<StoreViewModel>();
            var products = GetAllProducts();
            foreach (var item in products)
            {
                var category = item.Category.Id;
                var sellrates = context.Products.Where(c => c.CategoryId == category).Select(c => c.SellRate).ToList();
                int max_rate = sellrates.Max();
               if (item.SellRate == max_rate)
                {
                    StoreViewModel sv = new StoreViewModel()
                    {
                        CategoryName = item.Category.Name,
                        Top = products.Where(c => c.SellRate == max_rate).ToList()
                    };
                    vm.Add(sv);
                }
            }


            return vm;
        }
    }
}
