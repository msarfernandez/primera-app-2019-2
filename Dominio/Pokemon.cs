using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Tipo Tipo { get; set; }
        public Pokemon Evolucion { get; set; }
        public string UrlImagen { get; set; }

        //public Pokemon()
        //{
        //    Tipo = new Tipo();
        //}
        public override string ToString()
        {
            return Nombre;
        }

    }
}
