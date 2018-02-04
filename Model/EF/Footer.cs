﻿namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Footer")]
    public partial class Footer
    {
        [StringLength(50)]
        public string ID { get; set; }
        [Display(Name = "Nội dung")]
        [Column(TypeName = "ntext")]
        public string FooterContent { get; set; }

        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
    }
}
