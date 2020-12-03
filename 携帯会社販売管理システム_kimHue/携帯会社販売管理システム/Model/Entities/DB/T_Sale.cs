namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Sale()
        {
            T_SaleDetail = new HashSet<T_SaleDetail>();
        }

        [Key]
        [StringLength(6)]
        public string SaID { get; set; }

        [StringLength(4)]
        public string ClID { get; set; }

        public int? SOID { get; set; }

        [StringLength(4)]
        public string EmID { get; set; }

        [StringLength(6)]
        public string OrID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SadDate { get; set; }

        [StringLength(225)]
        public string SaHidden { get; set; }

        public virtual M_Client M_Client { get; set; }

        public virtual M_Employee M_Employee { get; set; }

        public virtual M_SalesOffice M_SalesOffice { get; set; }

        public virtual T_Order T_Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SaleDetail> T_SaleDetail { get; set; }
    }
}
