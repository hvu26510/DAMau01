using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMau01.DAL;

namespace DAMau01.BLL
{
    internal class AccountBLL
    {
        public string Login(string user, string pass)
        {
            // goi đến DAL kiểm tìm kiếm tài khoản
            // nếu user, pass đúng => trả về true, nếu không => false

            AccountDAL accountDal = new AccountDAL();

            var acc = accountDal.FindAccount(user);
            if (acc != null) 
            {
                if(acc.username==user && acc.password == pass)
                {
                    return "Đăng nhập thành công";
                }
                else
                {
                    return "Sai mật khẩu";
                }
            }
            else
            {
                return "Tai khoan khong ton tai";
            }

        }
    }
}
