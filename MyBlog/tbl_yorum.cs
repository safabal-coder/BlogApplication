namespace MyBlog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_yorum
    {
        [Key]
        public int YorumId { get; set; }

        [Required]
        [StringLength(1500)]
        public string Yorum { get; set; }

        public int MakaleId { get; set; }

        public DateTime EklenmeTarihi { get; set; }

        [Required]
        [StringLength(150)]
        public string AdSoyad { get; set; }

        public int Begeni { get; set; }

        public virtual tbl_makale tbl_makale { get; set; }
    }
}
