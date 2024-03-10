using Exceptions_Hometask.Exceptions;
using Exceptions_Hometask.Models;
using Exceptions_Hometask.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Controllers
{
    internal class AccountController : AccountService
    {
        public readonly AccountService accountService;


        public AccountController()
        {
            accountService = new AccountService();
        }

        // ------------ ???
        public string Login(string email, string password)
        {
            try
            {
                Console.WriteLine("Add your email:");
                string str = Console.ReadLine();


                if (str != email)
                {
                    throw new CustomLoginExceptions("Email is wrong");
                }


                Console.WriteLine("Add your password");
                string strr = Console.ReadLine();

                if (strr != password)
                {
                    throw new CustomPasswordException("Password is wrong");
                }


                return "Login succes";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }


    } 
}
