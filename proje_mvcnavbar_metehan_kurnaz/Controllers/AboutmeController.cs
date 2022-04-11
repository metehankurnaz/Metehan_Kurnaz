using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje_mvcnavbar_metehan_kurnaz.Controllers
{
    public class AboutmeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
