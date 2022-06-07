using OgrenciProjesi.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models.Concrete.DAL
{
    public class GenericDAL<T> : IRepository<T> where T : class, new()
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
        public List<T> GetAll()
        {
            using (var context = new OgrenciProjesiDbContext())
            {
                return context.Set<T>().ToList();
            }
        }
        public T GetById(int id)
        {
            using (var context = new OgrenciProjesiDbContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public T GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
