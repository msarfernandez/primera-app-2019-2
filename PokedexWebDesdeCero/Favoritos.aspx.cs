using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace PokedexWebDesdeCero
{
    public partial class Favoritos : System.Web.UI.Page
    {
        public List<Pokemon> listaFavoritos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                listaFavoritos = (List<Pokemon>)Session[Session.SessionID + "listaFavoritos"];

                var pokeQuitar = Request.QueryString["idQuitar"];
                if(pokeQuitar != null)
                {
                    Pokemon pokemonQuitar = listaFavoritos.Find(J => J.Id == int.Parse(pokeQuitar));
                    listaFavoritos.Remove(pokemonQuitar);
                    Session[Session.SessionID + "listaFavoritos"] = listaFavoritos;
                }
                else if(Request.QueryString["idpkm"] != null)
                {
                    //obtengo lista original (el listado completo)
                    List<Pokemon> listaOriginal = (List<Pokemon>)Session[Session.SessionID + "listaPokemons"];
                    var pokeSeleccionado = Convert.ToInt32(Request.QueryString["idpkm"]);
                    Pokemon pokemon = listaOriginal.Find(J => J.Id == pokeSeleccionado);

                    //obtengo la lista de favoritos de la session
                    if (listaFavoritos == null)
                        listaFavoritos = new List<Pokemon>();

                    listaFavoritos.Add(pokemon);
                    Session[Session.SessionID + "listaFavoritos"] = listaFavoritos;
                }

                

            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = "Aun no tenes favoritos";
                Response.Redirect("Error");
            }
        }
    }
}