using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using E_Kitap_Uygulamasi.Models;
using E_Kitap_Uygulamasi.Models.Configuration;

namespace E_Kitap_Uygulamasi.Data
{
    public class ApplicationDbContext : IdentityDbContext<Uye,Rol,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<KitapKategori> KitapKategoriler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatisDetay> SatisDetaylar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Rol> Roller { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RolCFG());
            builder.ApplyConfiguration(new UyeCFG());
            builder.ApplyConfiguration(new KitapCFG());
            builder.ApplyConfiguration(new YazarCFG());
            builder.ApplyConfiguration(new KategoriCFG());
            builder.ApplyConfiguration(new YayinEviCFG());
            builder.ApplyConfiguration(new KitapKategoriCFG());

            base.OnModelCreating(builder);
        }
    }
}
