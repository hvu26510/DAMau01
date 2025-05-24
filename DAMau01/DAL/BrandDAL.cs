using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMau01.Data;

namespace DAMau01.DAL
{
    internal class BrandDAL
    {
        DBDuAnMauEntities db = new DBDuAnMauEntities();

        public List<Brand> GetAll()
        {
            return db.Brands.ToList();
        }

        public Brand getBrandByID(int id)
        {
            var b = db.Brands.FirstOrDefault(x=> x.ID ==id);
            return b;
        }
        public bool Add(Brand b)
        {
            try
            {
                db.Brands.Add(b);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        public bool Update(Brand b)
        {
            try
            {
                var curBrand = db.Brands.FirstOrDefault(x=>x.ID==b.ID);
                if (curBrand != null) 
                {
                    curBrand.ID= b.ID;
                    curBrand.BrandName = b.BrandName;
                    curBrand.Description = b.Description;
                    curBrand.Status = b.Status;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
