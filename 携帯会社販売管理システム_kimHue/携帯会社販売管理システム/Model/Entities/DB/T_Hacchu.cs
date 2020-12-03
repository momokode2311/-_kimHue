namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Hacchu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Hacchu()
        {
            T_HacchuDetail = new HashSet<T_HacchuDetail>();
            T_Warehousing = new HashSet<T_Warehousing>();
        }

        [Key]
        [StringLength(6)]
        public string HaID { get; set; }

        [StringLength(6)]
        public string MaID { get; set; }

        [StringLength(4)]
        public string EmID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HaDate { get; set; }

        [StringLength(255)]
        public string HaHidden { get; set; }

        public virtual M_Employee M_Employee { get; set; }

        public virtual M_Maker M_Maker { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_HacchuDetail> T_HacchuDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Warehousing> T_Warehousing { get; set; }
    }
}
