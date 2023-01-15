﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kargo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KargoEntities1 : DbContext
    {
        public KargoEntities1()
            : base("name=KargoEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Araclar> Araclars { get; set; }
        public virtual DbSet<KullaniciGiri> KullaniciGiris { get; set; }
        public virtual DbSet<Musteriler> Musterilers { get; set; }
        public virtual DbSet<Sevkiyatlar> Sevkiyatlars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int AEkle(string aracTur, Nullable<int> aracKapasite, string aracSofor)
        {
            var aracTurParameter = aracTur != null ?
                new ObjectParameter("AracTur", aracTur) :
                new ObjectParameter("AracTur", typeof(string));
    
            var aracKapasiteParameter = aracKapasite.HasValue ?
                new ObjectParameter("AracKapasite", aracKapasite) :
                new ObjectParameter("AracKapasite", typeof(int));
    
            var aracSoforParameter = aracSofor != null ?
                new ObjectParameter("AracSofor", aracSofor) :
                new ObjectParameter("AracSofor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AEkle", aracTurParameter, aracKapasiteParameter, aracSoforParameter);
        }
    
        public virtual ObjectResult<AListele_Result> AListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AListele_Result>("AListele");
        }
    
        public virtual int ASil(Nullable<int> aracNo)
        {
            var aracNoParameter = aracNo.HasValue ?
                new ObjectParameter("AracNo", aracNo) :
                new ObjectParameter("AracNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ASil", aracNoParameter);
        }
    
        public virtual int AYenile(Nullable<int> aracNo, string aracTur, Nullable<int> aracKapasite, string aracSofor)
        {
            var aracNoParameter = aracNo.HasValue ?
                new ObjectParameter("AracNo", aracNo) :
                new ObjectParameter("AracNo", typeof(int));
    
            var aracTurParameter = aracTur != null ?
                new ObjectParameter("AracTur", aracTur) :
                new ObjectParameter("AracTur", typeof(string));
    
            var aracKapasiteParameter = aracKapasite.HasValue ?
                new ObjectParameter("AracKapasite", aracKapasite) :
                new ObjectParameter("AracKapasite", typeof(int));
    
            var aracSoforParameter = aracSofor != null ?
                new ObjectParameter("AracSofor", aracSofor) :
                new ObjectParameter("AracSofor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AYenile", aracNoParameter, aracTurParameter, aracKapasiteParameter, aracSoforParameter);
        }
    
        public virtual ObjectResult<Giris_Result> Giris(string kullaniciAdi, string sifre)
        {
            var kullaniciAdiParameter = kullaniciAdi != null ?
                new ObjectParameter("KullaniciAdi", kullaniciAdi) :
                new ObjectParameter("KullaniciAdi", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("Sifre", sifre) :
                new ObjectParameter("Sifre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Giris_Result>("Giris", kullaniciAdiParameter, sifreParameter);
        }
    
        public virtual int GirisEkle(string kullaniciAdSoyad, string kullaniciAdi, string sifre)
        {
            var kullaniciAdSoyadParameter = kullaniciAdSoyad != null ?
                new ObjectParameter("KullaniciAdSoyad", kullaniciAdSoyad) :
                new ObjectParameter("KullaniciAdSoyad", typeof(string));
    
            var kullaniciAdiParameter = kullaniciAdi != null ?
                new ObjectParameter("KullaniciAdi", kullaniciAdi) :
                new ObjectParameter("KullaniciAdi", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("Sifre", sifre) :
                new ObjectParameter("Sifre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GirisEkle", kullaniciAdSoyadParameter, kullaniciAdiParameter, sifreParameter);
        }
    
        public virtual int MEkle(Nullable<int> sevkiyatNo, string adSoyad, string adres, string telefon, string mail, string odemeDurumu)
        {
            var sevkiyatNoParameter = sevkiyatNo.HasValue ?
                new ObjectParameter("SevkiyatNo", sevkiyatNo) :
                new ObjectParameter("SevkiyatNo", typeof(int));
    
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var odemeDurumuParameter = odemeDurumu != null ?
                new ObjectParameter("OdemeDurumu", odemeDurumu) :
                new ObjectParameter("OdemeDurumu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MEkle", sevkiyatNoParameter, adSoyadParameter, adresParameter, telefonParameter, mailParameter, odemeDurumuParameter);
        }
    
        public virtual ObjectResult<MListele_Result> MListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MListele_Result>("MListele");
        }
    
        public virtual int MSil(Nullable<int> musteriNo)
        {
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("MusteriNo", musteriNo) :
                new ObjectParameter("MusteriNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MSil", musteriNoParameter);
        }
    
        public virtual int MYenile(Nullable<int> musteriNo, Nullable<int> sevkiyatNo, string adSoyad, string adres, string telefon, string mail, string odemeDurumu)
        {
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("MusteriNo", musteriNo) :
                new ObjectParameter("MusteriNo", typeof(int));
    
            var sevkiyatNoParameter = sevkiyatNo.HasValue ?
                new ObjectParameter("SevkiyatNo", sevkiyatNo) :
                new ObjectParameter("SevkiyatNo", typeof(int));
    
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var odemeDurumuParameter = odemeDurumu != null ?
                new ObjectParameter("OdemeDurumu", odemeDurumu) :
                new ObjectParameter("OdemeDurumu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MYenile", musteriNoParameter, sevkiyatNoParameter, adSoyadParameter, adresParameter, telefonParameter, mailParameter, odemeDurumuParameter);
        }
    
        public virtual int SEkle(string sevkiyatAdi, string sevkiyatAlimNoktasi, string sevkiyatUlasimNoktası, Nullable<int> mesafe, Nullable<decimal> mesafeTutar)
        {
            var sevkiyatAdiParameter = sevkiyatAdi != null ?
                new ObjectParameter("SevkiyatAdi", sevkiyatAdi) :
                new ObjectParameter("SevkiyatAdi", typeof(string));
    
            var sevkiyatAlimNoktasiParameter = sevkiyatAlimNoktasi != null ?
                new ObjectParameter("SevkiyatAlimNoktasi", sevkiyatAlimNoktasi) :
                new ObjectParameter("SevkiyatAlimNoktasi", typeof(string));
    
            var sevkiyatUlasimNoktasıParameter = sevkiyatUlasimNoktası != null ?
                new ObjectParameter("SevkiyatUlasimNoktası", sevkiyatUlasimNoktası) :
                new ObjectParameter("SevkiyatUlasimNoktası", typeof(string));
    
            var mesafeParameter = mesafe.HasValue ?
                new ObjectParameter("Mesafe", mesafe) :
                new ObjectParameter("Mesafe", typeof(int));
    
            var mesafeTutarParameter = mesafeTutar.HasValue ?
                new ObjectParameter("MesafeTutar", mesafeTutar) :
                new ObjectParameter("MesafeTutar", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SEkle", sevkiyatAdiParameter, sevkiyatAlimNoktasiParameter, sevkiyatUlasimNoktasıParameter, mesafeParameter, mesafeTutarParameter);
        }
    
        public virtual ObjectResult<SevkiyatMusteri_Result> SevkiyatMusteri()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SevkiyatMusteri_Result>("SevkiyatMusteri");
        }
    
        public virtual ObjectResult<SListele_Result> SListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SListele_Result>("SListele");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int SSil(Nullable<int> sevkiyatNo)
        {
            var sevkiyatNoParameter = sevkiyatNo.HasValue ?
                new ObjectParameter("SevkiyatNo", sevkiyatNo) :
                new ObjectParameter("SevkiyatNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SSil", sevkiyatNoParameter);
        }
    
        public virtual int SYenile(Nullable<int> sevkiyatNo, string sevkiyatAdi, string sevkiyatAlimNoktasi, string sevkiyatUlasimNoktası, Nullable<int> mesafe, Nullable<decimal> mesafeTutar)
        {
            var sevkiyatNoParameter = sevkiyatNo.HasValue ?
                new ObjectParameter("SevkiyatNo", sevkiyatNo) :
                new ObjectParameter("SevkiyatNo", typeof(int));
    
            var sevkiyatAdiParameter = sevkiyatAdi != null ?
                new ObjectParameter("SevkiyatAdi", sevkiyatAdi) :
                new ObjectParameter("SevkiyatAdi", typeof(string));
    
            var sevkiyatAlimNoktasiParameter = sevkiyatAlimNoktasi != null ?
                new ObjectParameter("SevkiyatAlimNoktasi", sevkiyatAlimNoktasi) :
                new ObjectParameter("SevkiyatAlimNoktasi", typeof(string));
    
            var sevkiyatUlasimNoktasıParameter = sevkiyatUlasimNoktası != null ?
                new ObjectParameter("SevkiyatUlasimNoktası", sevkiyatUlasimNoktası) :
                new ObjectParameter("SevkiyatUlasimNoktası", typeof(string));
    
            var mesafeParameter = mesafe.HasValue ?
                new ObjectParameter("Mesafe", mesafe) :
                new ObjectParameter("Mesafe", typeof(int));
    
            var mesafeTutarParameter = mesafeTutar.HasValue ?
                new ObjectParameter("MesafeTutar", mesafeTutar) :
                new ObjectParameter("MesafeTutar", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SYenile", sevkiyatNoParameter, sevkiyatAdiParameter, sevkiyatAlimNoktasiParameter, sevkiyatUlasimNoktasıParameter, mesafeParameter, mesafeTutarParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> ToplamArac()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ToplamArac");
        }
    
        public virtual ObjectResult<Nullable<int>> ToplamMüşteri()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ToplamMüşteri");
        }
    
        public virtual ObjectResult<Nullable<int>> ToplamSevkiyat()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ToplamSevkiyat");
        }
    }
}