namespace ConsoleApp2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbl_Musteriler> tbl_Musteriler { get; set; }
        public virtual DbSet<tbl_Rezervasyonlar> tbl_Rezervasyonlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Musteriler>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Musteriler>()
                .Property(e => e.Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Musteriler>()
                .Property(e => e.KullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Musteriler>()
                .Property(e => e.Parola)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Musteriler>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Musteriler>()
                .Property(e => e.TelNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Musteriler>()
                .HasMany(e => e.tbl_Rezervasyonlar)
                .WithRequired(e => e.tbl_Musteriler)
                .HasForeignKey(e => e.MusteriID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Rezervasyonlar>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);
        }
    }
}
