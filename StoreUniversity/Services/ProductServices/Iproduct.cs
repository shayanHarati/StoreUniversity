using StoreUniversity.DTOs.Store;
using StoreUniversityModels.Product;
using StoreUniversityModels.User;

namespace StoreUniversity.Services.ProductServices
{
    public interface Iproduct
    {
        List<IndexProductsViewModel> GetTopProducts();
        Product GetbestProduct();
        List<Product> GetAllProducts();
        Product GetproductById(int id);
        void CreateFavorits(int Id,string username);
        List<User_Favorits> GetFavorits();
    }
}
