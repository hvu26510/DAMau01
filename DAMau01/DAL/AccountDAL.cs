using DAMau01.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAMau01.DAL
{
    internal class AccountDAL
    {
        List<Account> list = new List<Account>()
        {
            new Account{username = "User01", password = "123456" },
            new Account{username = "User02", password = "654321" }
        };
        public Account FindAccount(string user)
        {
            var account = list.Find(x => x.username == user);
                        
            return account;
        }
    }
}
