using RestorantDemo.Models;
using RestorantDemo.Models.Repositories;
using RestorantDemo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestorantDemo.Controllers
{
    public class HomeController : Controller
    {
        private RestorantDBEntities objRestorantDBEntities;
        public HomeController()
        {
            objRestorantDBEntities = new RestorantDBEntities();
        }

        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository();

            ItemRepository objItemRepository = new ItemRepository();

            PaymentTypeRepository objPaymentTypeRepository = new PaymentTypeRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>(objCustomerRepository.GetAllCustomers(),objItemRepository.GetAllItems(),objPaymentTypeRepository.GetAllPaymentType());

            return View(objMultipleModels);
        }

        [HttpGet]
        public JsonResult GetItemUnitPrice(int itemId)
        {
            decimal UnitPrice = objRestorantDBEntities.Items.Single(model => model.ItemId == itemId).ItemPrice;

            return Json(UnitPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(OrderViewModel objOrderViewModel)
        {
            OrderRepository objOrderRepository = new OrderRepository();
            objOrderRepository.AddOrder(objOrderViewModel);



            return Json("Order hass been successfuly pleased", JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}