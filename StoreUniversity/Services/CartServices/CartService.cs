using Cart_Exam.Models;
using Microsoft.EntityFrameworkCore;
using StoreUniversity.Context.DataBase;
using StoreUniversity.DTOs.Store;
using StoreUniversity.Services.UserServices;
using StoreUniversityModels.Product;
using StoreUniversityModels.User;
using System.Security.Claims;


namespace StoreUniversity.Services.CartServices
{
    public class CartService : ICart
    {
        private IUser user;
        private DB context;
        public CartService(DB _cotext, IUser _user)
        {
            context = _cotext;
            user = _user;
        }

        public void AddDetails(Order order, int id)
        {
            context.orderDetails.Add(new OrderDetail()
            {
                OrderId = order.OrderId,
                Count = 1,
                Price = context.Products.Find(id).Price,
                ProductId = id
            });
        }

        public void addItem(Order order, int id, string userid)
        {
            context.orders.Add(order);
            context.SaveChanges();

            try
            {
                order.OrderId = context.orders.Single(c => c.UserId==userid).OrderId;
                AddDetails(order, id);
                context.SaveChanges();
            }
            catch
            {
                context.orders.Remove(order);
                context.SaveChanges();
               
            }

        }

        public void deleteDetail(OrderDetail orderDetail)
        {
            context.Remove(orderDetail);
            context.SaveChanges();
        }

        public OrderDetail GetById(int id)
        {
           return context.orderDetails.Find(id);
        }

        public OrderDetail GetDetails(Order order,int id)
        {
            return context.orderDetails.SingleOrDefault(d => d.OrderId == order.OrderId && d.ProductId == id);
        }

        public List<OrderDetail> GetDetailsByOrderId(Order order)
        {
            return context.orderDetails.Where(d => d.OrderId == order.OrderId).ToList();
        }

        public Order GetOrder(string orderid)
        {
           return  context.orders.SingleOrDefault(o => o.OrderId.ToString() == orderid && !o.IsFinaly);
        }
        public Order GetOrderByUserId(string UserId)
        {
            return context.orders.SingleOrDefault(o => o.UserId == UserId && !o.IsFinaly);
        }
        public int GetOrderSum(Order order)
        {
           return context.orderDetails.Where(o => o.OrderId == order.OrderId).Select(d => d.Count * d.Price).Sum();
        }

        public void Update(OrderDetail order)
        {
            context.Update(order);
            context.SaveChanges();
        }

        public void Update(Order order)
        {
            context.Update(order);
            context.SaveChanges();
        }
    }
}
