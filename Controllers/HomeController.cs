using BootstrapDemo.Models;
using BundleAndBootstrapMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BundleAndBootstrapMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Index2(int id)
        {
            var sergeModel = new SergeModel
            {
                BigID = id,
                Name = "Serge",
                Country = new List<string> { 
                    "USA",
                    "Ukraine",
                }
            };

            // View data short lived, can't use it
            //ViewData["BigID"] = sergeModel.BigID;

            SetMenu(id);

            return View(sergeModel);
        }

        [HttpPost]
        public ActionResult Index2(SergeModel sergeModel)
        {
            return View(sergeModel);
        }

        private void SetMenu(int bigID) {
            // to show or not menu
            bool isMenuAvailable = true;
            ViewData["isMenuAvailable"] = isMenuAvailable;

            // menu items, url will be generated based on ID
            var menuList = new Dictionary<int, string>{
                {1, "Menu Item One"},
                {2, "Menu Item Two"},
                {3, "Menu Item Three"},
            };
            ViewData["menuList"] = menuList;

            // let's explore load of data in Session object 
            // to avoid passing it though the parameters and loading from DB again
            Session["BigID"] = bigID;

            // if we need to pass more than one parameter, 
            // we need to include them in the class and pass it as an object
            var complexMenu = new List<MenuItem>{
                new MenuItem{ID = 1, BigID = bigID, Text="Menu Item One"},
                new MenuItem{ID = 2, BigID = bigID, Text="Menu Item Two"},
                new MenuItem{ID = 3, BigID = bigID, Text="Menu Item Three"},
            };

            ViewData["complexMenu"] = complexMenu;
        }


        // one parameter version
        public ActionResult MenuItem(int id) {
            return View(id);
        }

        // two parameters version
        public ActionResult ComplexMenuItem(int id, int bigID)
        {
            var menuItem = new MenuItem { ID = id, BigID = bigID };

            return View(menuItem);
        }

    }
}