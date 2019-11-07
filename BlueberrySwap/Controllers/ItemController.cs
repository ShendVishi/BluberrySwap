using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueberrySwap.Models;

namespace BlueberrySwap.Controllers
{
    public class ItemController : Controller
    {
        // GET: Items
        public ActionResult Index(int? pageIndex, string sortBy)
        {

            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace( sortBy ))
                sortBy = "Title";

            Item[] items = new Item[3];
            
            items[0] = new Item(){Id =0,Title="Bluberries", Description = "Some description", Price=3.5, Status = 1, UserId = 1};
            items[1] = new Item() { Id = 1, Title = "Bread", Description = "Handmade Bread", Price=2.1,Status = 1, UserId = 11 };
            items[2] = new Item() { Id = 2, Title = "Cheese", Description = "Delicious Cheese", Price=6,Status = 0, UserId = 2 };
            return View(items);
        }

        // EDIT: Item
        public ActionResult Edit(int id)
        {

            return Content("id=" + id);
        }

        // CREATE: Item
        public ActionResult Create()
        {

            return View();
        }

    }
}