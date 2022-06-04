﻿using BusTicketReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicketReservation.WebUI.Models
{
    public class RouteTicket
    {
        public List<Ticket> Tickets { get; set; }
        public List<Route> Routes { get; set; }
        public List<City> Cities { get; set; }
        public Route Route { get; set; }
        public string Date { get; set; }
        public string Clock { get; set; }
        public Ticket Ticket { get; set; }
    }
}
