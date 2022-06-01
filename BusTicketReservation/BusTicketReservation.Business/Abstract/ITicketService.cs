using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Business.Abstract
{
    public interface ITicketService
    {
        void Create(Ticket entity);
        List<Ticket> GetAll();
        void Update(Ticket entity);
        void Delete(Ticket entity);
        void CreateTicket(Ticket entity);
        List<Ticket> GetFullSeats(string FromWhere, string ToWhere, string Date, string Clock, double Price, int RouteId);
    }
}
