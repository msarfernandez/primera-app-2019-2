using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    public class Mascota
    {
        // forma larga de crear un atributo con su getter y setter.
        private string mNombre;// este es el atributo
        public string Nombre // esta es la propiedad.
        {
           get { return mNombre; }
           set {
                if (value.Length > 10)
                    throw new Exception("no puede ser mayor de 10 caracteres");
                else
                    mNombre = value;
            }
        }
        // var otraCosa = objeto.Nombre; // acá usa el GET
        // objeto.Nombre = "ALGO" // acá usa el SET

        // forma corta de crear una propiedad/atributo
        public string Color { get; set; }
        // Ojo, que no es lo mismo que esto:
        // public string algoPublico; // lo dejamos comentado porque no lo queremos.



        public virtual string comunicarse()
        {
            return "eeeeeeeee";
        }
    }
}
