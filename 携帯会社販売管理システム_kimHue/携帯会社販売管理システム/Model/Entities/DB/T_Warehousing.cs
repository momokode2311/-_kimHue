namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Warehousing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Warehousing()
        {
            T_WarehousingDetails = new HashSet<T_WarehousingDetails>();
        }

        [Key]
        [StringLength(6)]
        public string WaID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WaDate { get; set; }

        [StringLength(6)]
        public string HaID { get; set; }

        [StringLength(4)]
        public string EmID { get; set; }

        public int? WaFlag { get; set; }

        [StringLength(225)]
        public string WaHidden { get; set; }

        public virtual M_Employee M_Employee { get; set; }

        public virtual T_Hacchu T_Hacchu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_WarehousingDetails> T_WarehousingDetails { get; set; }
    }
}
