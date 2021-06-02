using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Produkt : BaseStruktur
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = " name does not match")]
        public string Name { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "din beskrivelse passer ikke til")]
        public string Beskrivelse { get; set; }
        [Required]
        [StringLength(9999, ErrorMessage = "prisen er alt for høj")]
        public int Pris { get; set; }

        [ForeignKey("Kategori.Id")]
        public int KategoriId { get; set; }
    }
}
