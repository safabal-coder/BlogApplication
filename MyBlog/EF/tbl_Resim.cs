namespace MyBlog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Resim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Resim()
        {
            tbl_makale = new HashSet<tbl_makale>();
        }

        [Key]
        public int ResimId { get; set; }

        [StringLength(250)]
        public string KucukBoyut { get; set; }

        [StringLength(250)]
        public string OrtaBoyut { get; set; }

        [StringLength(250)]
        public string BuyukBoyut { get; set; }

        [StringLength(250)]
        public string Video { get; set; }

        public int? MakaleId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_makale> tbl_makale { get; set; }

        public virtual tbl_makale tbl_makale1 { get; set; }
    }
}
