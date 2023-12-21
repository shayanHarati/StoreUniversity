using StoreUniversity.DTOs.Store;
using StoreUniversityModels.Product;

namespace StoreUniversity.Services.ProductServices
{
    public interface Iproduct
    {
        List<StoreViewModel> GetTopProducts();
        Product GetproductById(int id);
    }
}
