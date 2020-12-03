namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_HacchuDetail
    {
        [Key]
        [StringLength(6)]
        public string HaDetailID { get; set; }

        [StringLength(6)]
        public string HaID { get; set; }

        [StringLength(6)]
        public string PrID { get; set; }

        public int? HaQuantity { get; set; }

        public virtual M_Product M_Product { get; set; }

        public virtual T_Hacchu T_Hacchu { get; set; }
    }
}
