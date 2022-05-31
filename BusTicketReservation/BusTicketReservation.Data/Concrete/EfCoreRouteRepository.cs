using BusTicketReservation.Data.Abstract;
using BusTicketReservation.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Data.Concrete
{
    public class EfCoreRouteRepository : EfCoreGenericRepository<Route, BusContext>, IRouteRepository
    {
        public List<Route> GetRoutes(Route routes)
        {
            using (var context = new BusContext())
            {
                var route = context.Routes.Where(i => i.FromWhere == routes.FromWhere && i.ToWhere == routes.ToWhere && i.Date == routes.Date).ToList();
                return route;
            }
        }
    }
}
