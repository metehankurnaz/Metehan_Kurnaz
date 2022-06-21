using FinallyProject.Data.Abstract;
using FinallyProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyProject.Data.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
        private AppDbContext appDbContext
        {
            get { return appDbContext as AppDbContext; }
        }
    }
}
