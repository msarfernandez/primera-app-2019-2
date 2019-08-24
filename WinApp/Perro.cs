using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class Perro : Mascota
    {
        public string TipoPerro { get; set; }

        public override string comunicarse()
        {
            return "guau guau";
        }
    }
}
