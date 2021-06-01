using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Beskrivelse { get; set; }
        public int Pris { get; set; }

        public int KategoriId { get; set; }
    }
}
