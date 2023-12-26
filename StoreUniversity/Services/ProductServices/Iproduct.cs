using StoreUniversity.DTOs.Account;
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
        float GetOff(int id);
        string GetImage(int id);
        string GetCategory(int id);
        bool IsOwner(int Userid, int ProductId);
        Product GetById(int id);
        List< User_Favorits> GetFavorits();
    }
}
