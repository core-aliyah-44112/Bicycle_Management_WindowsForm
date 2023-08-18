namespace Do_An_BaoCao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XeDap")]
    public partial class XeDap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XeDap()
        {
            BaoDuongs = new HashSet<BaoDuong>();
            HoaDons = new HashSet<HoaDon>();
            ThueXes = new HashSet<ThueXe>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaXe { get; set; }

        public int MaNSX { get; set; }

        [Required]
        [StringLength(255)]
        public string TenXe { get; set; }

        [Required]
        [StringLength(255)]
        public string LoaiXe { get; set; }

        [Required]
        [StringLength(255)]
        public string ChatLuong { get; set; }

        public int GiaThue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoDuong> BaoDuongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThueXe> ThueXes { get; set; }
    }
}
