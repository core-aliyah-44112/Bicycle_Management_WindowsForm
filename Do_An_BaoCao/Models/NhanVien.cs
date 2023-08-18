namespace Do_An_BaoCao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [Required]
        [StringLength(255)]
        public string HoTenNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(255)]
        public string GioiTinh { get; set; }

        public int MaPB { get; set; }

        [Required]
        [StringLength(255)]
        public string GhiChu { get; set; }


        public virtual PhongBan PhongBan { get; set; }
    }
}
