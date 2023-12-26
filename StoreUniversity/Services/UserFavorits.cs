using StoreUniversity.Context.DataBase;
using StoreUniversityModels.User;

namespace StoreUniversity.Services
{
    public class UserFavorits:IUserFavorite
    {
        private DB context;
        public UserFavorits(DB _cotext)
        {
            context=_cotext;
        }

        public User_Favorits Check(int UserId,int ProductId)
        {
            return context.Favorits.FirstOrDefault(c => c.UserId == UserId && c.ProductId == ProductId);
        }

        public void Insert(User_Favorits fav)
        {
            context.Favorits.Add(fav);
            context.SaveChanges();
        }
    }
}
