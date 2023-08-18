using Do_An_BaoCao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.DAO
{
    class ThueXeDAO
    {
        QLThueXeDbContext db = new QLThueXeDbContext();
        public List<TX_XM_KH> getList()
        {
            List<TX_XM_KH> List = db.ThueXes
                .Join(
                db.XeDaps,
                tx => tx.MaXe,
                xd => xd.MaXe,
                (tx, xd) => new
                {
                    MaTX = tx.MaTX,
                    MaKH = tx.MaKH,
                    NgaySinh = tx.NgaySinh,
                    GioiTinh = tx.GioiTinh,
                    CMND = tx.CMND,
                    SoTKNH = tx.SoTKNH,
                    Email = tx.Email,
                    DiaChi = tx.DiaChi,
                    MaXe = xd.MaXe,
                    TenXe = tx.TenXe,
                    ChatLuong = tx.ChatLuong,
                    NgayThue = tx.NgayThue,
                    NgayTra = tx.NgayTra,
                    GiaThue = tx.GiaThue
                })
                .Join(
                db.KhachHangs,
                tx => tx.MaKH,
                kh => kh.MaKH,
                (tx, kh) => new TX_XM_KH
                {
                    MaTX = tx.MaTX,
                    MaKH = kh.MaKH,
                    NgaySinh = tx.NgaySinh,
                    GioiTinh = tx.GioiTinh,
                    CMND = tx.CMND,
                    SoTKNH = tx.SoTKNH,
                    Email = tx.Email,
                    DiaChi = tx.DiaChi,
                    MaXe = tx.MaXe,
                    TenXe = tx.TenXe,
                    ChatLuong = tx.ChatLuong,
                    NgayThue = tx.NgayThue,
                    NgayTra = tx.NgayTra,
                    GiaThue = tx.GiaThue
                })
                .ToList();
            return List;
        }
        public ThueXe getRow(int maxe)
        {
            ThueXe tx = db.ThueXes.Find(maxe);
            return tx;
        }
        public void Insert(ThueXe tx)
        {
            db.ThueXes.Add(tx);
            db.SaveChanges();
        }
        public void Update(ThueXe tx)
        {
            db.Entry(tx).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(ThueXe tx)
        {
            db.ThueXes.Remove(tx);
            db.SaveChanges();
        }
    }
}
