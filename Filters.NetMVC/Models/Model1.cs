namespace Filters.NetMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<SiteUsers> SiteUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logs>()
                .Property(e => e.KullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Logs>()
                .Property(e => e.ActionName)
                .IsUnicode(false);

            modelBuilder.Entity<Logs>()
                .Property(e => e.ControllerName)
                .IsUnicode(false);

            modelBuilder.Entity<Logs>()
                .Property(e => e.Bilgi)
                .IsFixedLength();

            modelBuilder.Entity<SiteUsers>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<SiteUsers>()
                .Property(e => e.Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<SiteUsers>()
                .Property(e => e.KullaniciAdi)
                .IsFixedLength();

            modelBuilder.Entity<SiteUsers>()
                .Property(e => e.Sifre)
                .IsUnicode(false);
        }
    }
}
