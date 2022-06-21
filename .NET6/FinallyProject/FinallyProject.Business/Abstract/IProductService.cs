using FinallyProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyProject.Business.Abstract
{
    public interface IProductService
    {
        public void Create(Product entity);
        public void Delete(Product entity);
        public void Update(Product entity);
        public Task<IEnumerable<Product>> GetAll();
        public Task<Product> GetById(int id);

    }
}
