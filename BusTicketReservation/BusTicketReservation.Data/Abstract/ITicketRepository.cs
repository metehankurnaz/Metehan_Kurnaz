using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Data.Abstract
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        public void CreateTicket(Ticket ticket);
        public List<Ticket> GetFullSeats(string FromWhere, string ToWhere, string Date, string Clock, double Price, int RouteId);
    }
}
