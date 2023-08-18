using Do_An_BaoCao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.DAO
{
    class KhachHangDAO
    {
        QLThueXeDbContext db = new QLThueXeDbContext();
        public List<KhachHang> getList()
        {
            List<KhachHang> List = db.KhachHangs.ToList();
            return List;
        }
        public KhachHang getRow(int makh)
        {
            KhachHang kh = db.KhachHangs.Find(makh);
            return kh;
        }
        public void Insert(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }
        public void Update(KhachHang kh)
        {
            db.Entry(kh).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(KhachHang kh)
        {
            db.KhachHangs.Remove(kh);
            db.SaveChanges();
        }
    }
}
