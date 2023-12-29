using Cart_Exam.Models;
using StoreUniversity.DTOs.Store;
using StoreUniversityModels.Product;

namespace StoreUniversity.Services.CartServices
{
    public interface ICart
    {
        Order GetOrder(string orderid);
        Order GetOrderByUserId(string userId);
        void addItem(Order order,int id,string userid);
        void AddDetails(Order order, int id);
        OrderDetail GetDetails(Order order,int id);
        void Update(OrderDetail order);
        void Update(Order order);
       List< OrderDetail> GetDetailsByOrderId(Order order);
        OrderDetail GetById(int id);
        void deleteDetail(OrderDetail orderDetail);
        int GetOrderSum(Order order);
    }
}
