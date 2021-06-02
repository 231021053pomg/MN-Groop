using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Kunde
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(13, ErrorMessage = "the Name you have given is to long shorting your name or get a new one")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "Your Last name is to long shorting it or get a new one")]
        public string LastName { get; set; }
        [Required]
        [StringLength(37, ErrorMessage = "The street name i to long the name does not eksist!! no road in dk is that long")]
        public string VejNavn { get; set; }
        public int PostNummer { get; set; }
        public int LoginId { get; set; }

    }
}
