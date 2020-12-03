namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Maker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public M_Maker()
        {
            T_Hacchu = new HashSet<T_Hacchu>();
        }

        [Key]
        [StringLength(6)]
        public string MaID { get; set; }

        [StringLength(20)]
        public string MaName { get; set; }

        [StringLength(100)]
        public string MaAdress { get; set; }

        [StringLength(13)]
        public string MaPhone { get; set; }

        [StringLength(7)]
        public string MaPostal { get; set; }

        [StringLength(13)]
        public string MaFAX { get; set; }

        public bool? MaFlag { get; set; }

        [StringLength(250)]
        public string MaHidden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Hacchu> T_Hacchu { get; set; }
    }
}
