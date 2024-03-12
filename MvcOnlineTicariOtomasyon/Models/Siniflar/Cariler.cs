using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Ad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Soyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string Sehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Mail { get; set; }
        public SatisHareket SatisHareket { get; set; }

    }
}