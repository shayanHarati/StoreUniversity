using StoreUniversity.DTOs.Account;
using StoreUniversityModels.User;

namespace StoreUniversity.Services.UserServices
{
    public interface IUser
    {
        int GetId(string UserName);
        bool IsExistsThisUser(string UserName);
        bool IsExistsThisUserEmail(string Email);
        bool IsExistsThisUser(string Password,string UserName);
        User FindUser(string username);
        int RegisterUser( RegisterViewModel user);
        User GetUserById(int id);
        void UpdateUser(User _user);

        void save();
    }
}
