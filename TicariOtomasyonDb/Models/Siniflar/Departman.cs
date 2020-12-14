using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Siniflar
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }

        [Column(TypeName = "Varchar2")]
        [StringLength(30)]
        public string DepartmanAd { get; set; }

        public ICollection<Personel> Personels { get; set; }
    }
}