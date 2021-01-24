namespace MyBlog
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_etiket> tbl_etiket { get; set; }
        public virtual DbSet<tbl_kategori> tbl_kategori { get; set; }
        public virtual DbSet<tbl_kullanici> tbl_kullanici { get; set; }
        public virtual DbSet<tbl_makale> tbl_makale { get; set; }
        public virtual DbSet<tbl_Resim> tbl_Resim { get; set; }
        public virtual DbSet<tbl_yazar> tbl_yazar { get; set; }
        public virtual DbSet<tbl_yorum> tbl_yorum { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_etiket>()
                .HasMany(e => e.tbl_makale)
                .WithMany(e => e.tbl_etiket)
                .Map(m => m.ToTable("tbl_MakaleEtiket").MapLeftKey("EtiketId").MapRightKey("MakaleId"));

            modelBuilder.Entity<tbl_kategori>()
                .HasMany(e => e.tbl_makale)
                .WithRequired(e => e.tbl_kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_makale>()
                .HasMany(e => e.tbl_Resim1)
                .WithOptional(e => e.tbl_makale1)
                .HasForeignKey(e => e.MakaleId);

            modelBuilder.Entity<tbl_makale>()
                .HasMany(e => e.tbl_yorum)
                .WithRequired(e => e.tbl_makale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Resim>()
                .HasMany(e => e.tbl_makale)
                .WithOptional(e => e.tbl_Resim)
                .HasForeignKey(e => e.ResimId);

            modelBuilder.Entity<tbl_yazar>()
                .HasMany(e => e.tbl_makale)
                .WithRequired(e => e.tbl_yazar)
                .WillCascadeOnDelete(false);
        }
    }
}
