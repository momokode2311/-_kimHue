namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_SalesOffice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public M_SalesOffice()
        {
            M_Client = new HashSet<M_Client>();
            M_Employee = new HashSet<M_Employee>();
            M_Product = new HashSet<M_Product>();
            T_Sale = new HashSet<T_Sale>();
            T_Shipment = new HashSet<T_Shipment>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOID { get; set; }

        [StringLength(50)]
        public string SOName { get; set; }

        [StringLength(100)]
        public string SOAddress { get; set; }

        [StringLength(13)]
        public string SOPnumber { get; set; }

        [StringLength(8)]
        public string SOPost { get; set; }

        [StringLength(11)]
        public string SOFax { get; set; }

        [StringLength(225)]
        public string SoHidden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_Client> M_Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_Employee> M_Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_Product> M_Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Sale> T_Sale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Shipment> T_Shipment { get; set; }
    }
}
