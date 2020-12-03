namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public M_Employee()
        {
            T_Arrival = new HashSet<T_Arrival>();
            T_Hacchu = new HashSet<T_Hacchu>();
            T_LoginHistory = new HashSet<T_LoginHistory>();
            T_Order = new HashSet<T_Order>();
            T_Sale = new HashSet<T_Sale>();
            T_Syukko = new HashSet<T_Syukko>();
            T_Warehousing = new HashSet<T_Warehousing>();
            T_WarehousingDetails = new HashSet<T_WarehousingDetails>();
        }

        [Key]
        [StringLength(4)]
        public string EmID { get; set; }

        [StringLength(50)]
        public string EmName { get; set; }

        public int? SOID { get; set; }

        public int? PoID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Hiredate { get; set; }

        [StringLength(10)]
        public string Passwork { get; set; }

        public bool? EmFlag { get; set; }

        [StringLength(255)]
        public string EmHidden { get; set; }

        [StringLength(11)]
        public string EmPnumber { get; set; }

        public virtual M_Position M_Position { get; set; }

        public virtual M_SalesOffice M_SalesOffice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Arrival> T_Arrival { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Hacchu> T_Hacchu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_LoginHistory> T_LoginHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Order> T_Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Sale> T_Sale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Syukko> T_Syukko { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Warehousing> T_Warehousing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_WarehousingDetails> T_WarehousingDetails { get; set; }
    }
}
