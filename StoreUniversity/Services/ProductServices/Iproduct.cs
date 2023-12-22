using StoreUniversity.DTOs.Store;
using StoreUniversityModels.Product;

namespace StoreUniversity.Services.ProductServices
{
    public interface Iproduct
    {
        List<IndexProductsViewModel> GetTopProducts();
        List<Product> GetAllProducts();
        Product GetproductById(int id);
    }
}
