using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PokedexWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            Usuario usuario = new Usuario();
            try
            {
                usuario.Nombre = txtUsuario.Text;
                usuario.Pass = txtPass.Text;
                usuario = negocio.login(usuario);
                if (usuario.Id != 0)
                    Response.Redirect("");
            }
            catch (Exception ex)
            {

            }
        }
    }
}