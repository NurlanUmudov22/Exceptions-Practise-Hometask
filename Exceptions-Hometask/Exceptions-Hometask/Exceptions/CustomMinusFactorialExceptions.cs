using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Exceptions
{
    public class CustomMinusFactorialExceptions : Exception
    {
        public CustomMinusFactorialExceptions(string msj): base( msj)
        {

        }
    }
}
