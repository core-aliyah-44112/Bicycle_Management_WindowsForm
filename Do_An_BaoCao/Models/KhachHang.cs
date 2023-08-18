namespace Do_An_BaoCao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKH { get; set; }

        [Required]
        [StringLength(255)]
        public string HoTenKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(255)]
        public string GioiTinh { get; set; }

        public int CMND { get; set; }

        public int SoTKNH { get; set; }

        public int SDT { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(255)]
        public string GhiChu { get; set; }

         
    }
}
