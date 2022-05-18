using BusTicketReservation.Data.Abstract;
using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Data.Concrete
{
    public class EfCoreTicketRepository : EfCoreGenericRepository<Ticket, BusContext>, ITicketRepository
    {
        public string GetClock(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCountBySeat(int routeId)
        {
            using (var context = new BusContext())
            {
                return context.Tickets
                    .Where(i => i.RouteId == routeId)
                    .Select(i => i.SeatNumber)
                    .Count();
            }
        }

        public string GetDate(int id)
        {
            using (var context = new BusContext())
            {
                var lastticketdate = context.Routes
                    .Where(i => i.RouteId == id)
                    .Select(i => i.Date)
                    .FirstOrDefault();
                return lastticketdate;
            }
        }

        public int GetId()
        {
            using (var context = new BusContext())
            {
                var id = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .Select(i => i.RouteId)
                    .FirstOrDefault();
                return id;
            }
        }

        public Ticket GetLastRecord()
        {
            using (var context = new BusContext())
            {
                var lastticket = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .FirstOrDefault();
                return lastticket;
            }
        }

        public List<int> GetSeat(int routeId)
        {
            using (var context = new BusContext())
            {
                var seat = context.Tickets
                    .Where(i => i.RouteId == routeId)
                    .Select(i => i.SeatNumber)
                    .ToList();
                return seat;
            }
        }
    }
}
