using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Business.Abstract
{
    public interface IRouteService
    {
        void Create(Route entity);
        List<Route> GetAll();
        void Update(Route entity);
        void Delete(Route entity);
        Route GetById(int id);
        List<Route> GetRoutes(Route route);
    }
}
