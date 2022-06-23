﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation.Core
{
    public static class JobManager
    {
        public static string Makeurl(string url)
        {
            //Kendisine gelen string değerin içindeki;
            //1) Türkçe karakterlerin yerine latin alfabesindeki karşılıklarını koyacak
            //2) Boşlukların yerine - işareti koyacak
            //3) Nokta (.)'ları kaldıracak.

            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");

            url = url.ToLower();

            url = url.Replace("ö", "o");
            url = url.Replace("ğ", "g");
            url = url.Replace("ş", "s");
            url = url.Replace("ü", "u");
            url = url.Replace("ç", "c");

            url = url.Replace("", "-");
            url = url.Replace(".", "");

            return url;
        }
    }
}
