using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models.Abstract
{
    public interface IRepository<T> where T:class, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetSingle(int id);
        List<T> GetAll();
    }
}
