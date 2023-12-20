using StoreUniversity.DTOs.Account;
using StoreUniversityModels.User;

namespace StoreUniversity.Services.UserServices
{
    public interface IUser
    {
        int GetId(string UserName);
        bool IsExistsThisUser(string UserName);
        bool IsExistsThisUserEmail(string Email);
        int RegisterUser( RegisterViewModel user);

        void save();
    }
}
