using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Order_detalise : BaseStruktur
    {
        
        
        [Required]
        [StringLength(99, ErrorMessage = "antalet it to mutch")]
        public int Antal { get; set; }

        [Required]
        [StringLength(9999, ErrorMessage = " to expinsive")]
        public int StkPris { get; set; }
       
        [ForeignKey("Produkt.Id")]
        public int ProduktId { get; set; }
        [ForeignKey("Order.Id")]
        public int Orderid { get; set; }
    }
}
