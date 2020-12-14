using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int Urunid { get; set; }

        [Column(TypeName = "Varchar2")]
        [StringLength(30)]
        public string UrunAd { get; set; }

        [Column(TypeName = "Varchar2")]
        [StringLength(30)]
        public string Marka { get; set; }

        public short Stok { get; set; }

        public decimal AlisFiyat { get; set; }

        public decimal SatisFiyat { get; set; }

        public int Durum { get; set; } //ürünün satış miktarının kritik olup olmadığını belirler.

        [Column(TypeName = "Varchar2")]
        [StringLength(250)]
        public string UrunGorsel { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}