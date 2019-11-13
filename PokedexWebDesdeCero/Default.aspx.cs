using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace PokedexWebDesdeCero
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (!IsPostBack)
                {
                    ddlPokemon.DataSource = negocio.listar();
                    ddlPokemon.DataTextField = "Nombre";
                    ddlPokemon.DataValueField = "Id";
                    ddlPokemon.DataBind();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            lblSeleccion.Text = "El id del pokemon seleccionado es: " + ddlPokemon.SelectedItem.Value;
        }
    }
}