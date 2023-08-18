namespace Do_An_BaoCao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [Key]
        public int MaTV { get; set; }

        [StringLength(200)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(200)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(200)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(220)]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(20)]
        public string Quyen { get; set; }
    }
}
