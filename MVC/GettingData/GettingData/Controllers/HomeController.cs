﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id,string name)
        {
            return "uygulama çalışıyor.";
        }
    }
}
