namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SaleDetail
    {
        [Key]
        [StringLength(6)]
        public string SaDetailID { get; set; }

        [StringLength(6)]
        public string SaID { get; set; }

        [StringLength(6)]
        public string PrID { get; set; }

        public int? SaQuantity { get; set; }

        public double? SaPrTotalPrice { get; set; }

        public virtual M_Product M_Product { get; set; }

        public virtual T_Sale T_Sale { get; set; }
    }
}
