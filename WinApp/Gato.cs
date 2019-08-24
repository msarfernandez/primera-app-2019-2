using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class Gato : Mascota
    {
        public string Origen { get; set; }

        public override string comunicarse()
        {
            return "miau miauuu";
        }
    }
}
