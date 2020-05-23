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
                dgvPokemons.DataSource = listaPokemons;
                dgvPokemons.DataBind();

                cboPokemons.DataSource = listaPokemons;
                cboPokemons.DataBind();

                //cboPokemons.Items.Add("Rojo");
                //cboPokemons.Items.Add("Azul");
                //cboPokemons.Items.Add("Verde");

                if (!IsPostBack)
                { //pregunto si es la primera carga de la page
                    txtNumeroPokemon.Text = "150";
                    

                    //esto es lo que necesitamos para el repeater.
                    //repetidor.DataSource = listaPokemons;
                    //repetidor.DataBind();
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

        protected void btnArgumento_Click(object sender, EventArgs e)
        {
            // recibimos un argumento desde un asp button a partir de su propiedad CommandArgument.
            // nota: esto por alguna razón no funciona normalmente con un foreach en el front, para ello
            // usamos un repeater para crear cada card de Pokemon y cambia un poco la forma de mapear cada parámetro del objeto a 
            // cada card.
            // lo primero es tener en el load la lista linkeada al repeater, que en este caso se llama "repetidor".
            // El repeater es un simple tag que va en el aspx y dentro del mismo tiene un itemtemplate en el cual
            // se escribe lo que queremos que se repita. 
            var argument = ((Button)sender).CommandArgument;
        }

        protected void dgvPokemons_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string idPoke = dgvPokemons.Rows[index].Cells[1].Text;
        }
    }
}