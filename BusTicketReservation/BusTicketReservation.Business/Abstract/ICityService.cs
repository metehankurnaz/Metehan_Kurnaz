using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Business.Abstract
{
    public interface ICityService
    {
        void Create(City entity);
        List<City> GetAll();
        void Update(City entity);
        void Delete(City entity);
        City GetById(int id);
    }
}
