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
        string GetDeparture(string departure);
        string GetArrival(string arrival);
        List<Route> GetTravel(string departure, string arrival);
        int GetRouteByStartEnd(string start, string R1, string R2, string R3, string end);
        Route GetRouteDetails(int id);
    }
}
