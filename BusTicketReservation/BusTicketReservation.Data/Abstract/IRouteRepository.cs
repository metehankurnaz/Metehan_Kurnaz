using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Data.Abstract
{
    public interface IRouteRepository : IRepository<Route>
    {
        List<Route> GetRoutes(Route route);
    }
}
