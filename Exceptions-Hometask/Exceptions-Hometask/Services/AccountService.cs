using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Services
{
    internal class AccountService
    {
        private readonly userService userService;


        public AccountService()
        {
            userService = new userService();
        }


        public bool Login(string email, string password)
        {
            var users = userService.GetAll();
            return users.Any(m => m.Email == email && m.Password == password);
        }
    }
}
