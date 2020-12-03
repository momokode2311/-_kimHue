namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_LoginHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LAID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LIdate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LOdate { get; set; }

        [StringLength(4)]
        public string EmID { get; set; }

        public virtual M_Employee M_Employee { get; set; }
    }
}
