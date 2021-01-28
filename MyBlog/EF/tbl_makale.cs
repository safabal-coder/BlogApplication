namespace MyBlog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_makale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_makale()
        {
            tbl_Resim1 = new HashSet<tbl_Resim>();
            tbl_yorum = new HashSet<tbl_yorum>();
            tbl_etiket = new HashSet<tbl_etiket>();
        }

        [Key]
        public int MakaleId { get; set; }

        [Required]
        [StringLength(100)]
        public string Baslik { get; set; }

        [Required]
        public string Icerik { get; set; }

        public DateTime EklenmeTarihi { get; set; }

        public int KategoriId { get; set; }

        public int GoruntulenmeSayisi { get; set; }

        public int Begeni { get; set; }

        public int YazarId { get; set; }

        public int? ResimId { get; set; }

        public virtual tbl_kategori tbl_kategori { get; set; }

        public virtual tbl_Resim tbl_Resim { get; set; }

        public virtual tbl_yazar tbl_yazar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Resim> tbl_Resim1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_yorum> tbl_yorum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_etiket> tbl_etiket { get; set; }
    }
}
