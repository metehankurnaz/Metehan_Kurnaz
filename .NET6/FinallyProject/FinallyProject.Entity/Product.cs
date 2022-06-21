using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyProject.Entity
{
    public class Product //internal'ı public'e çevirerek global yaptık.yani her yerden ulaşabilelim diye.
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }

    }
}
