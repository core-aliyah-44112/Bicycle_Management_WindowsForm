using Do_An_BaoCao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.DAO
{
    class PhongBanDAO
    {
        QLThueXeDbContext db = new QLThueXeDbContext();
        public List<PhongBan> getList()
        {
            List<PhongBan> List = db.PhongBans.ToList();
            return List;
        }             
        
        public PhongBan getRow(int mapb)
        {
            PhongBan pb = db.PhongBans.Find(mapb);
            return pb;
        }
        public void Insert(PhongBan pb)
        {
            db.PhongBans.Add(pb);
            db.SaveChanges();
        }
        public void Update(PhongBan pb)
        {
            db.Entry(pb).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(PhongBan pb)
        {
            db.PhongBans.Remove(pb);
            db.SaveChanges();
        }
    }
}
