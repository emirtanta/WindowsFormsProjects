using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestorantDemo.Models.Repositories
{
    public class ItemRepository
    {
        private RestorantDBEntities objRestorantDBEntities;

        public ItemRepository()
        {
            objRestorantDBEntities = new RestorantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from obj in objRestorantDBEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemId.ToString(),
                                      Selected = false
                                  }).ToList();

            return objSelectListItems;
        }
    }
}