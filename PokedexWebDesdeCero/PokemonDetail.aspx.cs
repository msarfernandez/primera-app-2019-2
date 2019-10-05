using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace PokedexWebDesdeCero
{
    public partial class PokemonDetail : System.Web.UI.Page
    {
        public Pokemon pokemon { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            List<Pokemon> listaPokemon;
            try
            {
                listaPokemon = negocio.listar();
                //
                // int numeroPokemon = Convert.ToInt32(Session["NumeroPokemon" + Session.SessionID]);
                var pokeSeleccionado = Convert.ToInt32(Request.QueryString["idpkm"]);
                pokemon = listaPokemon.Find(J => J.Id == pokeSeleccionado);


            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = ex;
                Response.Redirect("Error.aspx");
            }

        }
    }
}