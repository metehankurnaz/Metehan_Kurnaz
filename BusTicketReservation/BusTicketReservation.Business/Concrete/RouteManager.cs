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
    public class RouteManager : IRouteService
    {
        private IRouteRepository _routeRepository;
        public RouteManager(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }
        public void Create(Route entity)
        {
            _routeRepository.Create(entity);
        }

        public void Delete(Route entity)
        {
            _routeRepository.Delete(entity);
        }

        public List<Route> GetAll()
        {
            return _routeRepository.GetAll();
        }

        public Route GetById(int id)
        {
            return _routeRepository.GetById(id);
        }

        public List<Route> GetRoutes(Route route)
        {
            return _routeRepository.GetRoutes(route);
        }

        public void Update(Route entity)
        {
            _routeRepository.Update(entity);
        }
    }
}
