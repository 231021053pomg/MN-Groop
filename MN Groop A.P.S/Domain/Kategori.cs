using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Kategori
    {
        public Kategori()
        {
            Produkts = new List<Produkt>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Beskrivelse { get; set; }

        public List<Produkt> Produkts { get; set; }


    }
}
