using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Exceptions
{
    public class CustomLoginExceptions : Exception
    {
        public CustomLoginExceptions(string msj):base(msj) 
        {
        
        }
    }
}
