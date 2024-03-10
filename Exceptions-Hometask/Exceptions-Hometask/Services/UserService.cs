using Exceptions_Hometask.Exceptions;
using Exceptions_Hometask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Services
{
    internal class userService : User
    {

        public User[] GetAll()
        {

            User user1 = new()
            {
                Id = 1,
                Name = "Samir",
                Surname = "Samirov",
                Email = "samir@123.com",
                Age = 24,
                Password = "samir123"
            };


            User user2 = new()
            {   
                Id = 2,
                Name = "Sahib",
                Surname = "Sahibov",
                Email = "sahib@123.com",
                Age = 26,
                Password = "sahib123"
            };



            User user3 = new()
            {
                Id = 3,
                Name = "Ramil",
                Surname = "Ramilov",
                Email = "ramil@123.com",
                Age = 34,
                Password = "ramil123"
            };


            User user4 = new()
            {
                Id = 4,
                Name = "Huseyn",
                Surname = "Huseynov",
                Email = "huseyn@123.com",
                Age = 29,
                Password = "huseyn123"
            };

            User[] users = { user1, user2, user3, user4, };
            return users;


        }


    }
}
