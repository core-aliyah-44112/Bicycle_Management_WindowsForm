using Do_An_BaoCao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.DAO
{
    class ThanhVienDAO
    {
        QLThueXeDbContext db = new QLThueXeDbContext();
        public List<ThanhVien> getList()
        {
            List<ThanhVien> List = db.ThanhViens.ToList();
            return List;
        }
        public ThanhVien getRow(string username)
        {
            ThanhVien tv = db.ThanhViens.Where(m => m.TenDangNhap == username).FirstOrDefault();
            return tv;
        }
        public ThanhVien getRow(int matv)
        {
            ThanhVien tv = db.ThanhViens.Find(matv);
            return tv;
        }
        public int getCounnt()
        {
            return db.ThanhViens.Count();
        }
        public void Insert(ThanhVien tv)
        {
            db.ThanhViens.Add(tv);
            db.SaveChanges();
        }
        public void Update(ThanhVien tv)
        {
            db.Entry(tv).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(ThanhVien tv)
        {
            db.ThanhViens.Remove(tv);
            db.SaveChanges();
        }
    }
}
