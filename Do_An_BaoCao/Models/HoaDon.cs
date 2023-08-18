namespace Do_An_BaoCao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        public int MaKH { get; set; }

        [Required]
        [StringLength(255)]
        public string TenKH { get; set; }

        public int MaXe { get; set; }

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
        public DateTime NgayThue { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTra { get; set; }

        public int GiaThue { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual XeDap XeDap { get; set; }
    }
}
