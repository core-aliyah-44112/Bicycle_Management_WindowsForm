namespace Do_An_BaoCao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoDuong")]
    public partial class BaoDuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBD { get; set; }

        public int MaNV { get; set; }

        public int MaXe { get; set; }

        public int MaPB { get; set; }

        [Required]
        [StringLength(255)]
        public string TenXe { get; set; }

        [Required]
        [StringLength(255)]
        public string LoaiXe { get; set; }

        [Required]
        [StringLength(255)]
        public string ChatLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayBD { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        public virtual XeDap XeDap { get; set; }
    }
}
