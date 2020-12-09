namespace TicariOtomasyonDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "SYSTEM.Admin",
                c => new
                    {
                        AdminId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        KullaniciAd = c.String(maxLength: 10, unicode: false),
                        Sifre = c.String(maxLength: 30, unicode: false),
                        Yetki = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "SYSTEM.Carilers",
                c => new
                    {
                        CariId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        CariAd = c.String(maxLength: 30, unicode: false),
                        CariSoyad = c.String(maxLength: 30, unicode: false),
                        CariSehir = c.String(maxLength: 13, unicode: false),
                        CariMail = c.String(maxLength: 50, unicode: false),
                        SatisHareket_SatisId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.CariId)
                .ForeignKey("SYSTEM.SatisHarekets", t => t.SatisHareket_SatisId)
                .Index(t => t.SatisHareket_SatisId);
            
            CreateTable(
                "SYSTEM.SatisHarekets",
                c => new
                    {
                        SatisId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        Adet = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ToplamTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SatisId);
            
            CreateTable(
                "SYSTEM.Personels",
                c => new
                    {
                        PersonelId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        PersonelAd = c.String(maxLength: 30, unicode: false),
                        PersonelSoyad = c.String(maxLength: 30, unicode: false),
                        PersonelGorsel = c.String(maxLength: 250, unicode: false),
                        Departman_DepartmanId = c.Decimal(precision: 10, scale: 0),
                        SatisHareket_SatisId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.PersonelId)
                .ForeignKey("SYSTEM.Departmen", t => t.Departman_DepartmanId)
                .ForeignKey("SYSTEM.SatisHarekets", t => t.SatisHareket_SatisId)
                .Index(t => t.Departman_DepartmanId)
                .Index(t => t.SatisHareket_SatisId);
            
            CreateTable(
                "SYSTEM.Departmen",
                c => new
                    {
                        DepartmanId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        DepartmanAd = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.DepartmanId);
            
            CreateTable(
                "SYSTEM.Uruns",
                c => new
                    {
                        Urunid = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        UrunAd = c.String(maxLength: 30, unicode: false),
                        Marka = c.String(maxLength: 30, unicode: false),
                        Stok = c.Decimal(nullable: false, precision: 5, scale: 0),
                        AlisFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SatisFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Durum = c.Decimal(nullable: false, precision: 1, scale: 0),
                        UrunGorsel = c.String(maxLength: 250, unicode: false),
                        Kategori_KategoriID = c.Decimal(precision: 10, scale: 0),
                        SatisHareket_SatisId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Urunid)
                .ForeignKey("SYSTEM.Kategoris", t => t.Kategori_KategoriID)
                .ForeignKey("SYSTEM.SatisHarekets", t => t.SatisHareket_SatisId)
                .Index(t => t.Kategori_KategoriID)
                .Index(t => t.SatisHareket_SatisId);
            
            CreateTable(
                "SYSTEM.Kategoris",
                c => new
                    {
                        KategoriID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        KategoriAd = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "SYSTEM.FaturaKalems",
                c => new
                    {
                        FaturaKalemId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Aciklama = c.String(maxLength: 100, unicode: false),
                        Miktar = c.Decimal(nullable: false, precision: 10, scale: 0),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Faturalar_FaturaId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.FaturaKalemId)
                .ForeignKey("SYSTEM.Faturalars", t => t.Faturalar_FaturaId)
                .Index(t => t.Faturalar_FaturaId);
            
            CreateTable(
                "SYSTEM.Faturalars",
                c => new
                    {
                        FaturaId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        FaturaSeriNo = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        FaturaSıraNo = c.String(maxLength: 6, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                        VergiDairesi = c.String(maxLength: 60, unicode: false),
                        Saat = c.DateTime(nullable: false),
                        TeslimEden = c.String(maxLength: 30, unicode: false),
                        TeslimAlan = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.FaturaId);
            
            CreateTable(
                "SYSTEM.Giders",
                c => new
                    {
                        GiderId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Aciklama = c.String(maxLength: 100, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.GiderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("SYSTEM.FaturaKalems", "Faturalar_FaturaId", "SYSTEM.Faturalars");
            DropForeignKey("SYSTEM.Uruns", "SatisHareket_SatisId", "SYSTEM.SatisHarekets");
            DropForeignKey("SYSTEM.Uruns", "Kategori_KategoriID", "SYSTEM.Kategoris");
            DropForeignKey("SYSTEM.Personels", "SatisHareket_SatisId", "SYSTEM.SatisHarekets");
            DropForeignKey("SYSTEM.Personels", "Departman_DepartmanId", "SYSTEM.Departmen");
            DropForeignKey("SYSTEM.Carilers", "SatisHareket_SatisId", "SYSTEM.SatisHarekets");
            DropIndex("SYSTEM.FaturaKalems", new[] { "Faturalar_FaturaId" });
            DropIndex("SYSTEM.Uruns", new[] { "SatisHareket_SatisId" });
            DropIndex("SYSTEM.Uruns", new[] { "Kategori_KategoriID" });
            DropIndex("SYSTEM.Personels", new[] { "SatisHareket_SatisId" });
            DropIndex("SYSTEM.Personels", new[] { "Departman_DepartmanId" });
            DropIndex("SYSTEM.Carilers", new[] { "SatisHareket_SatisId" });
            DropTable("SYSTEM.Giders");
            DropTable("SYSTEM.Faturalars");
            DropTable("SYSTEM.FaturaKalems");
            DropTable("SYSTEM.Kategoris");
            DropTable("SYSTEM.Uruns");
            DropTable("SYSTEM.Departmen");
            DropTable("SYSTEM.Personels");
            DropTable("SYSTEM.SatisHarekets");
            DropTable("SYSTEM.Carilers");
            DropTable("SYSTEM.Admin");
        }
    }
}
