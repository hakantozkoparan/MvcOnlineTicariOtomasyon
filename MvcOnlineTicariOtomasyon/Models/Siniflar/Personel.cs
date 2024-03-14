using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Personel
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
        [StringLength(250)]
        public string Gorsel { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public Departman Departman { get; set; }

    }
}