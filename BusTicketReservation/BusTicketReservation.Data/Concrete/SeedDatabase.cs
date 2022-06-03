using BusTicketReservation.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Data.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new BusContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);
                }
                if (context.Routes.Count() == 0)
                {
                    context.Routes.AddRange(Routes);
                }
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);
                }
            }
            context.SaveChanges();
        }
        private static Route[] Routes =
        {
            new Route() {FromWhere="İstanbul",ToWhere="Kocaeli",Date="02.06.2022",Clock="10:30"},
            new Route() {FromWhere="Kocaeli",ToWhere="İstanbul",Date="02.06.2022",Clock="13:30"},
            new Route() {FromWhere="İstanbul",ToWhere="Bolu",Date="02.06.2022",Clock="09:00"},
            new Route() {FromWhere="Bolu",ToWhere="İstanbul",Date="02.06.2022",Clock="15:00"},
            new Route() {FromWhere="İstanbul",ToWhere="Ankara",Date="02.06.2022",Clock="07:30"},
            new Route() {FromWhere="Ankara",ToWhere="İstanbul",Date="02.06.2022",Clock="15:30"}
        };
        private static City[] Cities =
        {
            new City() {CityId=1,CityName="İstanbul"},
            new City() {CityId=2,CityName="Kocaeli"},
            new City() {CityId=3,CityName="Bolu"},
            new City() {CityId=4,CityName="Ankara"}
        };
        private static Ticket[] Tickets =
        {
            new Ticket() {Name="Yusuf",Surname="Koçak",FromWhere="İstanbul",ToWhere="Kocaeli",SeatNo=1,Price=100,RouteId=1},
            new Ticket() {Name="Serhan",Surname="Orhan",FromWhere="Kocaeli",ToWhere="İstanbul",SeatNo=2,Price=100,RouteId=2},
            new Ticket() {Name="Metehan",Surname="Kurnaz",FromWhere="İstanbul",ToWhere="Bolu",SeatNo=3,Price=150,RouteId=3},
            new Ticket() {Name="Ahmet",Surname="Kargin",FromWhere="Bolu",ToWhere="İstanbul",SeatNo=4,Price=150,RouteId=4},
            new Ticket() {Name="Arda",Surname="Girişit",FromWhere="İstanbul",ToWhere="Ankara",SeatNo=5,Price=200,RouteId=5},
            new Ticket() {Name="Furkan",Surname="Kaya",FromWhere="Ankara",ToWhere="İstanbul",SeatNo=6,Price=200,RouteId=5}
        };
    }
}
