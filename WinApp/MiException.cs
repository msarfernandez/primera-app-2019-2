using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    public class MiException : Exception
    {
        public MiException()
        {
            //Message = "ERROR CUSTOM"; // no se puede, cuack
        }
        public override string ToString()
        {
            return "Error de tipo MI ERROR";
        }
    }
}
