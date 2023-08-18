using Do_An_BaoCao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.DAO
{
    class XeDapDAO
    {
        QLThueXeDbContext db = new QLThueXeDbContext();
        public List<XeDap> getList()
        {
            List<XeDap> List = db.XeDaps.ToList();
            return List;
        }
       
        public XeDap getRow(int maxd)
        {
            XeDap xd = db.XeDaps.Find(maxd);
            return xd;
        }
        public int getCount()
        {
            return db.XeDaps.Count();
        }
        public void Insert(XeDap xd)
        {
            db.XeDaps.Add(xd);
            db.SaveChanges();
        }
        public void Update(XeDap xd)
        {
            db.Entry(xd).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(XeDap xd)
        {
            db.XeDaps.Remove(xd);
            db.SaveChanges();
        }
    }
}
