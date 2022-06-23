using BusTicketReservation.Business.Abstract;
using BusTicketReservation.Entity;
using BusTicketReservation.WebUI.EmailServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicketReservation.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICityService _cityService;
        private IRouteService _routeService;
        private ITicketService _ticketService;
        private IEmailSender _emailSender;
        public HomeController(ICityService cityService, IRouteService routeService, ITicketService ticketService, IEmailSender emailSender)
        {
            _cityService = cityService;
            _routeService = routeService;
            _ticketService = ticketService;
            _emailSender = emailSender;
        }
        public IActionResult Index()
        {
            ViewBag.cities = _cityService.GetAll();
            return View();
        }
        public IActionResult Ticket(Route route)
        {
            return View(_routeService.GetRoutes(route));
        }
        public IActionResult Passenger(string FromWhere, string ToWhere, string Date, string Clock, double Price, int RouteId)
        {
            var fullseats = _ticketService.GetFullSeats(FromWhere, ToWhere, Date, Clock, Price, RouteId);
            var seats = new List<int>();
            for (int i = 1; i < 35; i++)
            {
                seats.Add(i);
            }
            foreach (var item in fullseats)
            {
                seats.Remove(item.SeatNo);
            }

            ViewBag.seats = seats;
            Ticket ticket = new Ticket()
            {
                FromWhere = FromWhere,
                ToWhere = ToWhere,
                Date = Date,
                Clock = Clock,
                Price = Price,
                RouteId = RouteId
            };

            return View(ticket);
        }
        
        public IActionResult Reserved(Ticket ticket)
        {
            _ticketService.CreateTicket(ticket);
            return View(ticket);
        }
    }
}
