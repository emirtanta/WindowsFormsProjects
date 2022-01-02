using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestorantDemo.Models.Repositories
{
    public class PaymentTypeRepository
    {
        private RestorantDBEntities objRestorantDBEntities;

        public PaymentTypeRepository()
        {
            objRestorantDBEntities = new RestorantDBEntities();
        }

        public IEnumerable<SelectListItem>GetAllPaymentType()
        {
            var objSelectListItems = new List<SelectListItem>();

             objSelectListItems = (from obj in objRestorantDBEntities.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text=obj.PaymentTypeName,
                                      Value=obj.PaymentTypeId.ToString(),
                                      Selected=true
                                  }).ToList();

            return objSelectListItems;
        }

    }
}