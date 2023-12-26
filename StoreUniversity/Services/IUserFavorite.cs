using StoreUniversityModels.User;

namespace StoreUniversity.Services
{
    public interface IUserFavorite
    {
        User_Favorits Check (int UserId, int ProductId);
        void Insert(User_Favorits fav);
    }
}
