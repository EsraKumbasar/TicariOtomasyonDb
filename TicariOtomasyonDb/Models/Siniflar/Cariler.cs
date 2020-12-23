using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int CariId { get; set; }

        [Column(TypeName = "Varchar2")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter girebilirsiniz!")]
        public string CariAd { get; set; }

        [Column(TypeName = "Varchar2")]
        [StringLength(30)]
        [Required(ErrorMessage = "Bu alan boş olamaz!")]
        public string CariSoyad { get; set; }

        [Column(TypeName = "Varchar2")]
        [StringLength(13)]
        public string CariSehir { get; set; }

        [Column(TypeName = "Varchar2")]
        [StringLength(50)]
        public string CariMail { get; set; }

        public int Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    
}
}