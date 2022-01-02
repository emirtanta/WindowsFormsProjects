using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestorantDemo.Models.Repositories
{
    public class CustomerRepository
    {
        private RestorantDBEntities objRestorantDBEntities;

        public CustomerRepository()
        {
            objRestorantDBEntities = new RestorantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from obj in objRestorantDBEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}