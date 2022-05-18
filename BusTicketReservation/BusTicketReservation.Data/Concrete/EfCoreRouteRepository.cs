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
        public string GetArrival(string arrival)
        {
            using (var context = new BusContext())
            {
                var arr = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(arrival))
                    .Select(i => i.CityName)
                    .ToList();
                return arr[0];
            }
        }

        public string GetDeparture(string departure)
        {
            using (var context = new BusContext())
            {
                var dpr = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(departure))
                    .Select(i => i.CityName)
                    .ToList();
                return dpr[0];
            }
        }

        public int GetRouteByStartEnd(string start, string R1, string R2, string R3, string end)
        {
            throw new NotImplementedException();
        }

        public Route GetRouteDetails(int id)
        {
            using (var context = new BusContext())
            {
                return context.Routes
                    .Where(i => i.RouteId == id)
                    .AsNoTracking()
                    .FirstOrDefault();
            }
        }

        public List<Route> GetTravel(string departure, string arrival)
        {
            using (var context = new BusContext())
            {
                var dpr = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(departure))
                    .Select(i => i.CityName)
                    .ToList();
                var arr = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(arrival))
                    .Select(i => i.CityName)
                    .ToList();
                var routes = context.Routes
                    .FromSqlRaw($"select * from  Routes where  ((Start='{dpr[0]}' or R1 ='{dpr[0]}' or R2 ='{dpr[0]}' or R3 ='{dpr[0]}') and (End='{arr[0]}' or R3='{arr[0]}' or R2='{arr[0]}' or R1='{arr[0]}' ))")
            }
        }
    }
}
