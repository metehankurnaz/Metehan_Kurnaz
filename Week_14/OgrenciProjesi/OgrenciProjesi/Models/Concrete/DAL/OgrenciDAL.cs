using Microsoft.EntityFrameworkCore;
using OgrenciProjesi.Models.Abstract;
using OgrenciProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models.Concrete.DAL
{
    public class OgrenciDAL : GenericDAL<Ogrenci>, IOgrenciRepository
    {
        public Ogrenci GetByIdWithDers(int id)
        {
            using (var context = new OgrenciProjesiDbContext())
            {
                return context.Ogrencis
                    .Where(x => x.OgrenciId == id)
                    .Include(x => x.OgrenciDers)
                    .ThenInclude(x => x.Ders)
                    .FirstOrDefault();
            }
        }

        //CRUD
        public void GetWithBolum()
        {
            throw new NotImplementedException();
        }
    }
}
