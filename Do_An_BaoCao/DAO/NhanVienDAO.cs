using Do_An_BaoCao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.DAO
{
    class NhanVienDAO
    {
       
        QLThueXeDbContext db = new QLThueXeDbContext();
        public List<NV_BD_PB> getList()
        {
            List<NV_BD_PB> List = db.NhanViens
                .Join(
                db.PhongBans,
                nv => nv.MaPB,
                pb => pb.MaPB,
                (nv, pb) => new NV_BD_PB
                {
                    MaPB = pb.MaPB,
                    MaNV = nv.MaNV,
                    HoTenNV = nv.HoTenNV,
                    GhiChu = nv.GhiChu,
                    NgaySinh = nv.NgaySinh,
                    GioiTinh = nv.GioiTinh

                })
                .ToList();
            return List;
        }

        public NhanVien getRow(int manv)
        {
            NhanVien nv = db.NhanViens.Find(manv);
            return nv;
        }
        public int getCount()
        {
            return db.NhanViens.Count();
        }
        public void Insert(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }
        public void Update(NhanVien nv)
        {
            db.Entry(nv).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(NhanVien nv)
        {
            db.NhanViens.Remove(nv);
            db.SaveChanges();
        }
    }
}
