namespace MyBlog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_kullanici
    {
        [Key]
        public int KullaniciId { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyadi { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string Parola { get; set; }

        [Required]
        [StringLength(50)]
        public string MailAdresi { get; set; }

        public bool? Cinsiyet { get; set; }

        public DateTime? DogumTarihi { get; set; }

        public DateTime KayitTarihi { get; set; }
    }
}
