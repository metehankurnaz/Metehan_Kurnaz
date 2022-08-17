using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer(){FirstName="metehan",LastName="kurnaz"},
            new Customer(){FirstName="erhan",LastName="kurnaz"},
            new Customer(){FirstName="gülhan",LastName="kurnaz"}
        };
        public IActionResult UseViewModel()
        {
            Product product = new Product();
            product.ProductName = "Monitör";
            product.CategoryName = "Elektronik";
            product.UnitPrice = 1000;

            string date = DateTime.Now.ToString();

            CustomerProductVM customerProductVM = new CustomerProductVM();
            customerProductVM.customers = customers;
            customerProductVM.product = product;
            customerProductVM.date = date;

            return View(customerProductVM);
        }

        public IActionResult UseTuple()
        {
            Product product = new Product();
            product.ProductName = "Telefon";
            product.CategoryName = "Elektronik";
            product.UnitPrice = 4000;

            string date = DateTime.Now.ToString();

            (Product,List<Customer>,string) customerAndProduct = (product,customers,date);

            return View(customerAndProduct);
        }
    }
}
