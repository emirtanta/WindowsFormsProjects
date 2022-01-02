using RestorantDemo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestorantDemo.Models.Repositories
{
    public class OrderRepository
    {
        private RestorantDBEntities objRestorantDBEntities;
        public OrderRepository()
        {
            objRestorantDBEntities = new RestorantDBEntities();
        }

        public bool AddOrder(OrderViewModel objOrderViewModel)
        {
            Orders objOrder = new Orders();
            objOrder.CustomerId = objOrderViewModel.CustomerId;
            objOrder.FinalTotal = objOrderViewModel.FinalTotal;
            objOrder.OrderDate = objOrderViewModel.OrderDate;
            objOrder.OrderNumber = String.Format("{0:ddmmmyyyyhhmmss}",DateTime.Now);
            objOrder.PaymentTypeId = objOrderViewModel.PaymentTypeId;

            objRestorantDBEntities.Orders.Add(objOrder);
            objRestorantDBEntities.SaveChanges();

            int OrderId = objOrder.OrderId;

            foreach (var item in objOrderViewModel.ListOfOrderDetailViewModel)
            {
                OrderDetails objOrderDetail = new OrderDetails();
                objOrderDetail.OrderId = OrderId;
                objOrderDetail.Discount = item.Discount;
                objOrderDetail.ItemId = item.ItemId;
                objOrderDetail.Total = item.Total;
                objOrderDetail.UnitPrice = item.UnitPrice;
                objOrderDetail.Quantity = item.Quantity;

                objRestorantDBEntities.Orders.Add(objOrderDetail);
                objRestorantDBEntities.SaveChanges();

                Transactions objTransaction = new Transactions();
                objTransaction.ItemId = item.ItemId;
                objTransaction.Quantity =(-1)* item.Quantity;
                objTransaction.TransactionDate = DateTime.Now;
                objTransaction.TypeId = 2;

                objRestorantDBEntities.Transactions.Add(objTransaction);

                objRestorantDBEntities.SaveChanges();
            }

            return true;
        }
    }
}