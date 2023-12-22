using StoreUniversity.DTOs.Store;
using StoreUniversityModels.Product;

namespace StoreUniversity.Services.ProductServices
{
    public interface Iproduct
    {
        List<StoreViewModel> GetTopProducts();
        List<Product> GetAllProducts();
        Product GetproductById(int id);
    }
}
