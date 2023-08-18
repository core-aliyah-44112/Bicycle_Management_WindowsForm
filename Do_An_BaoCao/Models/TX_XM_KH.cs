using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.Models
{
    class TX_XM_KH
    {
        public int MaTX { get; set; }

        public int MaKH { get; set; }

        public DateTime NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public int CMND { get; set; }

        public int SoTKNH { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }

        public int MaXe { get; set; }

        public string TenXe { get; set; }
        public string ChatLuong { get; set; }

        public DateTime NgayThue { get; set; }

        public DateTime NgayTra { get; set; }

        public int GiaThue { get; set; }
    }
}
