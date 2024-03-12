﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email {  get; set; }
        
        public string Password { get; set; }
       
        public int Age { get; set; }

    }
}
