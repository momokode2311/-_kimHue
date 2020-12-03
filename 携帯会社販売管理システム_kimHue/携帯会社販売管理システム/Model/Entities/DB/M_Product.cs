namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public M_Product()
        {
            T_ArrivalDetail = new HashSet<T_ArrivalDetail>();
            T_HacchuDetail = new HashSet<T_HacchuDetail>();
            T_OrderDetail = new HashSet<T_OrderDetail>();
            T_SaleDetail = new HashSet<T_SaleDetail>();
            T_ShipmentDetail = new HashSet<T_ShipmentDetail>();
            T_SyukkoDetails = new HashSet<T_SyukkoDetails>();
            T_WarehousingDetails = new HashSet<T_WarehousingDetails>();
        }

        [Key]
        [StringLength(6)]
        public string PrID { get; set; }

        [StringLength(50)]
        public string PrName { get; set; }

        public int? SOID { get; set; }

        public double? PrUnitPrice { get; set; }

        [StringLength(10)]
        public string PrTotal { get; set; }

        public bool? PDFlag { get; set; }

        [StringLength(225)]
        public string PrHidden { get; set; }

        public int? Mnumber { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Rdate { get; set; }

        [StringLength(13)]
        public string PrCode { get; set; }

        public virtual M_SalesOffice M_SalesOffice { get; set; }

        public virtual T_Stock T_Stock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ArrivalDetail> T_ArrivalDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_HacchuDetail> T_HacchuDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_OrderDetail> T_OrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SaleDetail> T_SaleDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ShipmentDetail> T_ShipmentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SyukkoDetails> T_SyukkoDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_WarehousingDetails> T_WarehousingDetails { get; set; }
    }
}
