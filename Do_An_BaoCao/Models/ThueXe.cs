namespace Do_An_BaoCao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThueXe")]
    public partial class ThueXe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTX { get; set; }

        public int MaKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(255)]
        public string GioiTinh { get; set; }

        public int CMND { get; set; }

        public int SoTKNH { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string DiaChi { get; set; }

        public int MaXe { get; set; }

        [Required]
        [StringLength(255)]
        public string TenXe { get; set; }

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
