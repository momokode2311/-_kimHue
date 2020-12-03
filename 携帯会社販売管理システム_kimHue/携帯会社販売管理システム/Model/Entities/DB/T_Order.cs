namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Order()
        {
            T_Arrival = new HashSet<T_Arrival>();
            T_OrderDetail = new HashSet<T_OrderDetail>();
            T_Sale = new HashSet<T_Sale>();
            T_Shipment = new HashSet<T_Shipment>();
        }

        [Key]
        [StringLength(6)]
        public string OrID { get; set; }

        public int? SOID { get; set; }

        [StringLength(4)]
        public string EmID { get; set; }

        [StringLength(4)]
        public string ClID { get; set; }

        [StringLength(50)]
        public string ClCharge { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrDate { get; set; }

        public bool? OrStateFlag { get; set; }

        public int? OrFlag { get; set; }

        [StringLength(225)]
        public string OrHidden { get; set; }

        public virtual M_Employee M_Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Arrival> T_Arrival { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_OrderDetail> T_OrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Sale> T_Sale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Shipment> T_Shipment { get; set; }
    }
}
