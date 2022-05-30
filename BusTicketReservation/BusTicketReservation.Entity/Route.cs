using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Entity
{
    public class Route
    {
        public int RouteId { get; set; }
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public string Date { get; set; }
        public string Clock { get; set; }
        public double Price { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
