using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MiniShopApp.WebUI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {//WebUI Extension Klas�r� olu�turduk - MigrateDatabase 'i tan�mlad�k.
            CreateHostBuilder(args).Build().MigrateDatabase().Run(); //MigrateDatabase metodu olu�turduk. Oto-Migrate i�in!
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
