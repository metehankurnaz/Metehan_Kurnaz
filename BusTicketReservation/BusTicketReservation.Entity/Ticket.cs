using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int SeatNumber { get; set; }
        public double Price { get; set; }
        public Route Route { get; set; }
        public int RouteId { get; set; }
    }
}
