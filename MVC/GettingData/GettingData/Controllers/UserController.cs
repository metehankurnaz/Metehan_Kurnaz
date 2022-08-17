using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
        {
            new User() {FirstName="Metehan",LastName="Zurnaz"},
            new User() {FirstName="Gulhan",LastName="Zurnaz"},
            new User() {FirstName="Zizem",LastName="Zurnaz"},
            new User() {FirstName="Zerhan",LastName="Zurnaz"}
        };
        public IActionResult AddUser()
        {
            return View(users);
        }

        [HttpPost]
        public IActionResult AddUser(User user) // (User user) olarak da gönderebiliriz
        {
            users.Add(user);
            return View("AddUser",users);
        }
    }
}
