namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Shipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Shipment()
        {
            T_ShipmentDetail = new HashSet<T_ShipmentDetail>();
        }

        [Key]
        [StringLength(6)]
        public string ShID { get; set; }

        public int? SOID { get; set; }

        [StringLength(6)]
        public string OrID { get; set; }

        public int? ShStateFlag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShFinishDate { get; set; }

        public bool? ShFlag { get; set; }

        [StringLength(225)]
        public string ShHidden { get; set; }

        public virtual M_SalesOffice M_SalesOffice { get; set; }

        public virtual T_Order T_Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ShipmentDetail> T_ShipmentDetail { get; set; }
    }
}
