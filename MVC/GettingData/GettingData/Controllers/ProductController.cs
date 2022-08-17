using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){ID=1,ProductName="kitap",CategoryName="egitim"},
            new Product(){ID=2,ProductName="televizyon",CategoryName="elektronik"},
            new Product(){ID=3,ProductName="kalem",CategoryName="kirtasiye"},
            new Product(){ID=4,ProductName="silgi",CategoryName="kirtasiye"}
        };
        public IActionResult GetAllProducts()
        {
            return View(products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);
            return View("GetAllProducts",products);
        }

        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x => x.ID == id);
            if (product == null)
            {
                ViewBag.Error = "Verilen id ile bir ürün bulunamadı!";
            }
            return View(product);
        }

        public IActionResult GetCategories(string categoryname)
        {
            List<Product> product2 = products.FindAll(y => y.CategoryName == categoryname);

            if (product2.Count == 0)
            {
                ViewBag.Error2 = "verilen kategoride bir ürün bulunamadı.";
            }

            return View(product2);
        }

        
    }
}

