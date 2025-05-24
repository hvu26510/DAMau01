using DAMau01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMau01.Data;

namespace DAMau01.BLL
{
    internal class BrandBLL
    {
        BrandDAL BrandDAL = new BrandDAL();

        public List<Brand> getAllBrand()
        {
            return BrandDAL.GetAll();
        }

        public string SaveBrand(Brand brand)
        {
            var CurBrand = BrandDAL.getBrandByID(brand.ID);
            if (CurBrand == null) 
            {
                if (BrandDAL.Add(brand))
                {
                    return "Them thanh cong";
                }
                return "Them that bai";
            }
            else
            {
             
                if (BrandDAL.Update(brand))
                {
                    return "Sua thanh cong";
                }
                return "Sua that bai";
            }

            return "";
        }

    }
}
