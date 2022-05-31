using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Data.Concrete
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City, BusContext>, ICityRepository
    {
        
    }
}
