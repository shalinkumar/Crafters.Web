using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crafters.Web.Model;

namespace Crafters.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<CraftItems> craftItemsModel = new List<CraftItems>();
            for(int i=0;i<10;i++)
            {
                craftItemsModel.Add(new CraftItems
                {
                    Id = i,
                    ItemName = "Item-" + i + "",
                    Description = "ItemDescriptions-" + i + "",
                    Price = i,
                });
            }
            return View(craftItemsModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
