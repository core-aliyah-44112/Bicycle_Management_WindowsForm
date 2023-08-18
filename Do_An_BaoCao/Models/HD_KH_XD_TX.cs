using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.Models
{
    class HD_KH_XD_TX
    {
        public int MaHD { get; set; }

        public int MaKH { get; set; }

        public string TenKH { get; set; }

        public int MaXe { get; set; }

        public string TenXe { get; set; }

        public string LoaiXe { get; set; }

        public string ChatLuong { get; set; }

        public DateTime NgayThue { get; set; }

        public DateTime NgayTra { get; set; }

        public int GiaThue { get; set; }
    }
}
