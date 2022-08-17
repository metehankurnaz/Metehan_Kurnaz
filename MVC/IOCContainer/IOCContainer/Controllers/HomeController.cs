using IOCContainer.Services;
using IOCContainer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOCContainer.Controllers
{
    public class HomeController : Controller
    {
        //ConsoleLogger _log;
        ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }

        public string Index()
        {
            _log.Info("index action içerisine bir action gelmiştir.");
            return "Service running";
        }
    }
}
