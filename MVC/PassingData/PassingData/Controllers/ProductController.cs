using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "metehan";
            return View(userName as Object);
        }

        public IActionResult UrunGoster()
        {
            Product product = new Product();
            product.ProductName = "Televizyon";
            product.UnitPrice = 5;
            return View(product);
        }

        public IActionResult GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ProductName="Bilgisayar",CategoryName="Elektronik",UnitPrice=7000},
                new Product(){ProductName="Telefon",CategoryName="Elektronik",UnitPrice=5000},
                new Product(){ProductName="Buzdolabı",CategoryName="Beyaz Eşya",UnitPrice=7000},
                new Product(){ProductName="Koltuk",CategoryName="Elektronik",UnitPrice=7000}
            };
            return View(products);
        }
    }
}
