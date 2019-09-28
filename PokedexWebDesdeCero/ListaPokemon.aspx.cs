using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace PokedexWebDesdeCero
{
    public partial class ListaPokemon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                dgvPokemones.DataSource = negocio.listar();
                dgvPokemones.DataBind();

                if(!IsPostBack)
                    txtTextbox.Text = "Bienvenide";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void dgvPokemones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtNavegar_Click(object sender, EventArgs e)
        {
            try
            {
                var algo = txtTextbox.Text;

                if (txtTextbox.Text == "HOLA")
                    Response.Redirect("/Index.aspx");
                else
                    Response.Redirect("/Default.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}