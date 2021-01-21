namespace MyBlog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Resim
    {
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

        public virtual tbl_makale tbl_makale { get; set; }
    }
}
