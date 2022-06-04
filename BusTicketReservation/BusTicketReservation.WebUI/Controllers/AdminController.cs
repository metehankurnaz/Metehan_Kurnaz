using BusTicketReservation.Business.Abstract;
using BusTicketReservation.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicketReservation.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private ITicketService _ticketService;
        public AdminController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public IActionResult AdminPage()
        {
            return View(new RouteTicket() { 
            Tickets = _ticketService.GetAll()
            });
        }

        public IActionResult DeleteTicket(int ticketId)
        {
            var ticket = _ticketService.GetById(ticketId);
            if (ticket != null)
            {
                _ticketService.Delete(ticket);
            }
            return RedirectToAction("AdminPage");
        }
    }
}
