using Do_An_BaoCao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.DAO
{
    class BaoDuongDAO
    {
        QLThueXeDbContext db = new QLThueXeDbContext();
        public List<BD_NV_PB_XD> getList()
        {
            List<BD_NV_PB_XD> List = db.BaoDuongs
                .Join(
                db.NhanViens,
                bd => bd.MaNV,
                nv => nv.MaNV,
                (bd,nv)=> new
                {
                    MaBD = bd.MaBD,
                    MaNV = nv.MaNV,
                    MaXe = bd.MaXe,
                    MaPB=bd.MaPB,
                    TenXe = bd.TenXe,
                    LoaiXe = bd.LoaiXe,
                    ChatLuong = bd.ChatLuong,
                    NgayBD = bd.NgayBD
                })
                 .Join(
                db.XeDaps,
                bd => bd.MaXe,
                nv => nv.MaXe,
                (bd, nv) => new
                {
                    MaBD = bd.MaBD,
                    MaNV = bd.MaNV,
                    MaXe = nv.MaXe,
                    MaPB = bd.MaPB,
                    TenXe = bd.TenXe,
                    LoaiXe = bd.LoaiXe,
                    ChatLuong = bd.ChatLuong,
                    NgayBD = bd.NgayBD
                })
                  .Join(
                db.PhongBans,
                bd => bd.MaPB,
                nv => nv.MaPB,
                (bd, nv) => new BD_NV_PB_XD
                {
                    MaBD = bd.MaBD,
                    MaNV = bd.MaNV,
                    MaXe = bd.MaXe,
                    MaPB = nv.MaPB,
                    TenXe = bd.TenXe,
                    LoaiXe = bd.LoaiXe,
                    ChatLuong = bd.ChatLuong,
                    NgayBD = bd.NgayBD
                })
                .ToList();
            return List;
        }
        public BaoDuong getRow(int mabd)
        {
            BaoDuong bd = db.BaoDuongs.Find(mabd);
            return bd;
        }
        public void Insert(BaoDuong bd)
        {
            db.BaoDuongs.Add(bd);
            db.SaveChanges();
        }
        public void Update(BaoDuong bd)
        {
            db.Entry(bd).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(BaoDuong bd)
        {
            db.BaoDuongs.Remove(bd);
            db.SaveChanges();
        }
    }
}
