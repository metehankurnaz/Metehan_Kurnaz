using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models.Entities
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public string DersOgretmeni { get; set; }
        public int Kredi { get; set; }
        public string Donemi { get; set; }
        public List<OgrenciDers> OgrenciDers { get; set; }

    }
}
