namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SyukkoDetails
    {
        [Key]
        [StringLength(6)]
        public string SyDID { get; set; }

        public int? SyDquantity { get; set; }

        [StringLength(6)]
        public string PrID { get; set; }

        [StringLength(6)]
        public string SyID { get; set; }

        public virtual M_Product M_Product { get; set; }

        public virtual T_Syukko T_Syukko { get; set; }
    }
}
