using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjesi.Models.Entities
{
    public class OgrenciDers
    {
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
