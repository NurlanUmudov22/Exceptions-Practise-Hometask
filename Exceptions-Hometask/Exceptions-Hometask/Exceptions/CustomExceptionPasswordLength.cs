using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Exceptions
{
    internal class CustomExceptionPasswordLength : Exception
    {
        public CustomExceptionPasswordLength(string msj) :base(msj) 
        {
        }

    }
}
