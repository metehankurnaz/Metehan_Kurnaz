using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
            {
                new User(){FirstName="Erhan",LastName="Kurnaz"},
                new User(){FirstName="Gizem",LastName="Kurnaz"},
                new User(){FirstName="Metehan",LastName="Kurnaz"}
            };
        public IActionResult UseViewBag()
        {
            ViewBag.UserName = "Metehan";

            User user = new User();
            user.FirstName = "gulhan";
            user.LastName = "kurnaz";
            ViewBag.User = user;
            
            ViewBag.Users = users;
            return View();
        }

        public IActionResult UseViewData()
        {
            //VIEWBAG'DEN FARKLI ["key"] array tanımlamak zorundasın! ViewBag Dinamik - ViewData Object!
            ViewData["UserName"] = "Ramazan";

            User user = new User();
            user.FirstName = "emirhan";
            user.LastName = "yeşil";
            ViewData["User"] = user;

            ViewData["Users"] = users;
            return View();
        }

        public IActionResult UseTempData()
        {
            TempData["name"] = "metehan";
            return View();
        }

        public IActionResult TempDataTest()
        {
            string userName = TempData["name"].ToString();
            return View();
        }
    }
}
