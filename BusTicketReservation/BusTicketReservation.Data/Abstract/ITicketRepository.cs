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
        int GetCountBySeat(int routeId);
        List<int> GetSeat(int routeId);
        Ticket GetLastRecord();
        int GetId();
        string GetDate(int id);
        string GetClock(int id);
    }
}
