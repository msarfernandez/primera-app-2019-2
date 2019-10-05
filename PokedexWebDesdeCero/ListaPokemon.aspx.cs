using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace PokedexWebDesdeCero
{
    public partial class ListaPokemon : Page
    {
        public List<Pokemon> listaPokemons { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                listaPokemons = negocio.listar();
                //dgvPokemones.DataSource = negocio.listar();
                //dgvPokemones.DataBind();

                //cboPokemons.DataSource = listaPokemons;
                //cboPokemons.DataBind();

                if (!IsPostBack)
                { //pregunto si es la primera carga de la page
                    txtNumeroPokemon.Text = "150";
                    cboPokemons.Items.Add("Rojo");
                    cboPokemons.Items.Add("Azul");
                    cboPokemons.Items.Add("Verde");
                }

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
                //var algo = txtTextbox.Text;

                //if (txtTextbox.Text == "HOLA")
                //    Response.Redirect("/Index.aspx");
                //else
                //    Response.Redirect("/Default.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void txtNumeroPokemon_TextChanged(object sender, EventArgs e)
        {
            string algo = txtNumeroPokemon.Text;

            if(Convert.ToInt32(algo) <= 151)
            {
                Session["NumeroPokemon" + Session.SessionID] = algo;
                Response.Redirect("PokemonDetail.aspx");
            }
            else
            {
                Session["Error" + Session.SessionID] = "El pokemon debe ser menor o igual a 151";
                Response.Redirect("Error.aspx");
            }
        }
    }
}