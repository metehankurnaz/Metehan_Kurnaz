using OgrenciProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models
{
    public class OgrenciModel
    {
        public int OgrenciId { get; set; }
        public int OgrenciNo { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string Donemi { get; set; }
        public string BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public List<Ders> SeciliDersler { get; set; }
    }
}
