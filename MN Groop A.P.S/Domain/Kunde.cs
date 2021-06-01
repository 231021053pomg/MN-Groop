using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Kunde
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VejNavn { get; set; }
        public int PostNummer { get; set; }
        public int MyProperty { get; set; }
        public int LoginId { get; set; }

    }
}
