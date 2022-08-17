using Interfaces.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MsSqlOperation mssql = new MsSqlOperation();
            mssql.Connection();

            ISqlOperation mysql = new MySqlOperation();
            mysql.Connection();


            ISqlOperation sql = new MsSqlOperation();
            sql.Connection();
            return View();
        }
    }
}
