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
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public string Date { get; set; }
        public string Clock { get; set; }
        public int SeatNo { get; set; }
        public double Price { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
}
