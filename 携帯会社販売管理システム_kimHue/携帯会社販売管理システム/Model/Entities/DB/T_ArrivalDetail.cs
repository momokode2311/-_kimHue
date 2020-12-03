namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ArrivalDetail
    {
        [Key]
        [StringLength(6)]
        public string ArDetailID { get; set; }

        [StringLength(6)]
        public string ArID { get; set; }

        [StringLength(6)]
        public string PrID { get; set; }

        public int ArQuantity { get; set; }

        public virtual M_Product M_Product { get; set; }

        public virtual T_Arrival T_Arrival { get; set; }
    }
}
