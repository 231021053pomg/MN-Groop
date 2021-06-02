using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Order_detalise
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(99, ErrorMessage = "antalet it to mutch")]
        public int Antal { get; set; }
        public int StkPris { get; set; }
        public int ProduktId { get; set; }
        public int OrderId { get; set; }
    }
}
