using DBClass.DAO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClass.Service
{
    public class Login:ILogin
    {
        public DBConnection _DbCon;
        public Login(DBConnection Con)
        {
            _DbCon = Con;
        }

        public async Task<bool> DoLogin(string username, string password)
        {
           return  await _DbCon.Users.AnyAsync(s => s.UserName == username && s.Password == password);
        }
    }
}
