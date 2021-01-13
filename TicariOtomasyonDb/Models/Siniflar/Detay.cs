
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Siniflar
{
    public class Detay
    {
        [Key]
        public int DetayID { get; set; }
        [Column(TypeName = "Varchar2")]
        [StringLength(30)]
        public string urunad { get; set; }
        [Column(TypeName = "Varchar2")]
        [StringLength(2000)]
        public string urunbilgi { get; set; }

    }
}