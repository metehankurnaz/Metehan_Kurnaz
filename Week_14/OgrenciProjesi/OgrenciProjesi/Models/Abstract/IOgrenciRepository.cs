using OgrenciProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models.Abstract
{
    public interface IOgrenciRepository : IRepository<Ogrenci>
    {
        public void GetWithBolum();
        public Ogrenci GetByIdWithDers(int id);
    }
}
