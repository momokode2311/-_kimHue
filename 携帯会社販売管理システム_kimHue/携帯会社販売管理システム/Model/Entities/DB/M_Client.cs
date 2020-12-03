namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public M_Client()
        {
            T_Sale = new HashSet<T_Sale>();
        }

        [Key]
        [StringLength(4)]
        public string ClID { get; set; }

        [StringLength(50)]
        public string ClName { get; set; }

        public int? SOID { get; set; }

        [StringLength(50)]
        public string ClGender { get; set; }

        [StringLength(50)]
        public string ClJob { get; set; }

        [StringLength(100)]
        public string ClAddress { get; set; }

        [StringLength(11)]
        public string ClPnumber { get; set; }

        public bool? ClFlag { get; set; }

        [StringLength(225)]
        public string ClHidden { get; set; }

        [StringLength(7)]
        public string ClPostal { get; set; }

        [StringLength(50)]
        public string ClEmail { get; set; }

        [StringLength(11)]
        public string ClFax { get; set; }

        [StringLength(4)]
        public string EmID { get; set; }

        public virtual M_SalesOffice M_SalesOffice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Sale> T_Sale { get; set; }
    }
}
