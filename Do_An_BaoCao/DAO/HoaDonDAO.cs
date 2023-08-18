using Do_An_BaoCao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.DAO
{
    class HoaDonDAO
    {

        QLThueXeDbContext db = new QLThueXeDbContext();
        public List<HD_KH_XD_TX> getList()
        {
            List<HD_KH_XD_TX> List = db.HoaDons
                .Join(
                db.KhachHangs,
                hd => hd.MaKH,
                kh => kh.MaKH,
                (hd, kh) => new
                {
                    MaHD = hd.MaHD,
                    MaKH = kh.MaKH,
                    TenKH = hd.TenKH,
                    MaXe = hd.MaXe,
                    TenXe = hd.TenXe,
                    LoaiXe = hd.LoaiXe,
                    ChatLuong = hd.ChatLuong,
                    NgayThue = hd.NgayThue,
                    NgayTra = hd.NgayTra,
                    GiaThue = hd.GiaThue
                })
                .Join(
                db.XeDaps,
                hd => hd.MaXe,
                xd => xd.MaXe,
                (hd, xd) => new HD_KH_XD_TX
                {
                    MaHD = hd.MaHD,
                    MaKH = hd.MaKH,
                    TenKH = hd.TenKH,
                    MaXe = xd.MaXe,
                    TenXe = hd.TenXe,
                    LoaiXe = hd.LoaiXe,
                    ChatLuong = hd.ChatLuong,
                    NgayThue = hd.NgayThue,
                    NgayTra = hd.NgayTra,
                    GiaThue = hd.GiaThue
                }).ToList();
            return List;
        }
        public HoaDon getRow(int mahd)
        {
            HoaDon hd = db.HoaDons.Find(mahd);
            return hd;
        }
        public void Insert(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            db.SaveChanges();
        }
        public void Update(HoaDon hd)
        {
            db.Entry(hd).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(HoaDon hd)
        {
            db.HoaDons.Remove(hd);
            db.SaveChanges();
        }
    }
}
