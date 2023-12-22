using StoreUniversity.Context.DataBase;
using StoreUniversityModels.Product;

namespace StoreUniversity.Services.CategoryServices
{
    public class CategoryService : ICategory
    {
        private DB context;
        public CategoryService(DB _context)
        {
            context = _context;
        }
        public List<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }
    }
}
