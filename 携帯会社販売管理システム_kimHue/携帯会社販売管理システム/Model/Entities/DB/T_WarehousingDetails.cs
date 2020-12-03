namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_WarehousingDetails
    {
        [Key]
        [StringLength(6)]
        public string WDID { get; set; }

        [StringLength(6)]
        public string WaID { get; set; }

        public int? WDquantity { get; set; }

        [StringLength(6)]
        public string PrID { get; set; }

        [StringLength(4)]
        public string EmID { get; set; }

        public virtual M_Employee M_Employee { get; set; }

        public virtual M_Product M_Product { get; set; }

        public virtual T_Warehousing T_Warehousing { get; set; }
    }
}
