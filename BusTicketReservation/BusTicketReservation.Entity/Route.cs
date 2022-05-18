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
        public string Start { get; set; }
        public string R1 { get; set; }
        public string R2 { get; set; }
        public string R3 { get; set; }
        public string End { get; set; }
        public string Date { get; set; }
        public string Clock { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
