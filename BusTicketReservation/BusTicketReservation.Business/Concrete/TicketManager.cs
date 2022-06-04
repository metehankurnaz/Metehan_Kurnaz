using BusTicketReservation.Business.Abstract;
using BusTicketReservation.Data.Abstract;
using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        private ITicketRepository _ticketRepository;
        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public void Create(Ticket entity)
        {
            _ticketRepository.Create(entity);
        }

        public void CreateTicket(Ticket entity)
        {
            _ticketRepository.CreateTicket(entity);
        }

        public void Delete(Ticket entity)
        {
            _ticketRepository.Delete(entity);
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepository.GetAll();
        }

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public List<Ticket> GetFullSeats(string FromWhere, string ToWhere, string Date, string Clock, double Price, int RouteId)
        {
            return _ticketRepository.GetFullSeats(FromWhere, ToWhere, Date, Clock, Price, RouteId);
        }

        public void Update(Ticket entity)
        {
            _ticketRepository.Update(entity);
        }
    }
}
