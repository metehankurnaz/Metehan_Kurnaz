using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models.Entities
{
    public class Bolum
    {
        public int BolumId { get; set; }
        public string BolumAdi { get; set; }
        public string BolumBaskani { get; set; }
        public List<Ogrenci> Ogrencis { get; set; }
    }
}
