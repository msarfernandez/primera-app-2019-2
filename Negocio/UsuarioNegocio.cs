using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public Usuario login(Usuario usuario)
        {
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearQuery("select Id from USUARIOS Where Usuario = @usuario and Pass = @pass");
				datos.agregarParametro("@usuario", usuario.Nombre);
				datos.agregarParametro("@pass", usuario.Pass);

				datos.ejecutarLector();
				if (datos.lector.Read())
					usuario.Id = (int)datos.lector["Id"];

				return usuario;
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
