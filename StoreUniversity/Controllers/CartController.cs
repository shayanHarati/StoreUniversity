using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cart_Exam.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreUniversity.Core;
using StoreUniversity.DTOs.Store;
using StoreUniversity.Services.CartServices;
using StoreUniversity.Services.ProductServices;

namespace Cart_Exam.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private ICart  _ctx;
        private Iproduct _ptx;
        public OrdersController(ICart ctx,Iproduct ptx)
        {
            _ctx = ctx;
            _ptx = ptx;
        }
        
        public IActionResult AddToCart(int id)
        {
            string CurrentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Order order = _ctx.GetOrderByUserId(CurrentUserID);
            if (order == null)
            {
                order = new Order()
                {
                    UserId = CurrentUserID,
                    CreateDate = DateTime.Now,
                    IsFinaly = false,
                    Sum = 0
                };
                _ctx.addItem(order,id,CurrentUserID);
            }
            else
            {
                var details = _ctx.GetDetails(order, id);
                if (details == null)
                {
                    _ctx.AddDetails(order, id);
                }
                else
                {
                    details.Count += 1;
                    _ctx.Update(details);
                }

               
            }
            UpdateSumOrder(order.OrderId);
            return Redirect("/");
        }

        public IActionResult ShowOrder()
        {
            string CurrentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Order order = _ctx.GetOrderByUserId(CurrentUserID);

            List<ShowOrderViewModel> _list = new List<ShowOrderViewModel>();
            if (order != null)
            {
                
                var details = _ctx.GetDetailsByOrderId(order);
                foreach (var item in details)
                {

                    var product = _ptx.GetproductById(item.ProductId);

                    var off = 0;
                    if (product.Offcodes[0].Offcode != null)
                    {
                        off = product.Offcodes[0].Offcode.Percent;
                    }
                    _list.Add(new ShowOrderViewModel()
                    {
                        Count = item.Count,
                        ImageName = product.images[0].ImageName,
                        OrderDetailId = item.OrderDetailID,
                        Price = ApplyOff.Calculate(item.Price, off)*item.Count,
                        Sum = item.Count * item.Price,
                        Title = product.Name
                    });

                }
            }

            return View("Cart",_list);
        }

        public IActionResult Delete(int id)
        {
            var orderDetail = _ctx.GetById(id);
            if (orderDetail.Count > 1)
            {
                orderDetail.Count -= 1;
                _ctx.Update(orderDetail);
            }
            else
            {
                _ctx.deleteDetail(orderDetail);
            }
            
            return RedirectToAction("ShowOrder");
        }

        //public IActionResult Command(int id, string command)
        //{
        //    var orderDetail = _ctx.OrderDetails.Find(id);

        //    switch (command)
        //    {
        //        case "up":
        //            {
        //                orderDetail.Count += 1;
        //                _ctx.Update(orderDetail);
        //                break;
        //            }
        //        case "down":
        //            {
        //                orderDetail.Count -= 1;
        //                if (orderDetail.Count == 0)
        //                {
        //                    _ctx.OrderDetails.Remove(orderDetail);
        //                }
        //                else
        //                {
        //                    _ctx.Update(orderDetail);
        //                }

        //                break;
        //            }
        //    }


        //    _ctx.SaveChanges();
        //    return RedirectToAction("ShowOrder");
        //}
        public void UpdateSumOrder(int orderId)
        {

            var order = _ctx.GetOrder(orderId.ToString());
            order.Sum = _ctx.GetOrderSum(order);
            _ctx.Update(order);
            
        }
    }
}