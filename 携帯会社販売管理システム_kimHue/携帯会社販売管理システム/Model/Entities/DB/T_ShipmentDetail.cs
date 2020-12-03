namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ShipmentDetail
    {
        [Key]
        [StringLength(6)]
        public string ShDetailID { get; set; }

        [StringLength(6)]
        public string ShID { get; set; }

        [StringLength(6)]
        public string PrID { get; set; }

        public int? ShDquantity { get; set; }

        public virtual M_Product M_Product { get; set; }

        public virtual T_Shipment T_Shipment { get; set; }
    }
}
