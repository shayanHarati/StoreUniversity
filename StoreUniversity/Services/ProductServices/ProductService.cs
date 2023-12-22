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
            var prod= context.Products.Include(c=>c.Category).Include(c=>c.Offcodes).ToList();
            foreach (var item in prod)
            {
                var off = context.ProductsTOOffcodes.Include(c => c.Product).Include(c => c.Offcode).Where(c => c.ProductId == item.Id).ToList().Select(c=>c.Offcode).MaxBy(c => c.Percent);
                ProductsTOOffcodes vm = new ProductsTOOffcodes()
                {
                    Offcode = off,
                    Product=item
                };
                item.Offcodes.Clear();
                item.Offcodes.Add(vm);
            }
            return prod;
        }

        public Product GetproductById(int id)
        {
           return context.Products.Single(c => c.Id == id);
        }

        public List<IndexProductsViewModel> GetTopProducts()
        {
            List<IndexProductsViewModel> vm = new List<IndexProductsViewModel>();
            var products = GetAllProducts();
            foreach (var item in products)
            {
                var category = item.Category.Id;
                var sellrates = context.Products.Where(c => c.CategoryId == category).Select(c => c.SellRate).ToList();
                int max_rate = sellrates.Max();
               if (item.SellRate == max_rate)
                {
                    IndexProductsViewModel sv = new IndexProductsViewModel()
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
