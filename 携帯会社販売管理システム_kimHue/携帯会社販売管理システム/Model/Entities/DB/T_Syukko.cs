namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Syukko
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Syukko()
        {
            T_SyukkoDetails = new HashSet<T_SyukkoDetails>();
        }

        [Key]
        [StringLength(6)]
        public string SyID { get; set; }

        public bool? DMFlag { get; set; }

        [StringLength(4)]
        public string EmID { get; set; }

        [StringLength(4)]
        public string ClID { get; set; }

        [StringLength(6)]
        public string OrID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SyDate { get; set; }

        [StringLength(255)]
        public string SyHidden { get; set; }

        public virtual M_Employee M_Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SyukkoDetails> T_SyukkoDetails { get; set; }
    }
}
