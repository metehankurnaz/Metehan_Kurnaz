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
        public void CreateTicket(Ticket ticket)
        {
            using (var context = new BusContext())
            {
                context.Add(ticket);
                context.SaveChanges();
            }
        }

        public List<Ticket> GetFullSeats(string FromWhere, string ToWhere, string Date, string Clock, double Price, int RouteId)
        {
            using (var context = new BusContext())
            {
                var fullseats = context.Routes.Where(i => i.FromWhere == FromWhere && i.ToWhere == ToWhere && i.Date == Date && i.Clock == Clock && i.Price == Price).ToList();
                return fullseats;
            }
        }
    }
}
