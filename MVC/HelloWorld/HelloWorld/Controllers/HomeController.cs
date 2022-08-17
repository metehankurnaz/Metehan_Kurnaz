using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller    //controller
    {
        public string Index()        //action
        {
            return "Uygulama çalışıyor..";
        }

        public string Test()
        {
            return "bu test action'ıdır.";
        }

        public IActionResult Selamla()
        {
            ViewResult result = View();
            return result;
        }

        public IActionResult Selamla2()
        {
            ViewResult result = View();
            return result;
        }
    }
}
