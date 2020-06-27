using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PokedexWebDesdeCero
{
    public partial class DropDowns : System.Web.UI.Page
    {
		public string urlImagen { get; set; }
		protected void Page_Load(object sender, EventArgs e)
        {
			PokemonNegocio negocio = new PokemonNegocio();
			TipoNegocio negocioTipo = new TipoNegocio();
			try
			{
				if (!IsPostBack)
				{
					List<Pokemon> listaPokemon = negocio.listarConView();

					//configuro desplegable desde db pero solo lo cargo
					Session["listaPokemon"] = listaPokemon;
					ddlPokemons.DataSource = listaPokemon;
					ddlPokemons.DataBind();


					List<Tipo> listaTipos = negocioTipo.listar();

					//configuro desplegable desde db con id y desc
					ddlTipos.DataSource = listaTipos;
					ddlTipos.DataTextField = "Descripcion";
					ddlTipos.DataValueField = "Id";
					ddlTipos.DataBind();

					//configuro de tipos para preseleccionar
					ddlTipoPreseleccionado.DataSource = listaTipos;
					ddlTipoPreseleccionado.DataTextField = "Descripcion";
					ddlTipoPreseleccionado.DataValueField = "Id";
					ddlTipoPreseleccionado.DataBind();


				}
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		protected void txtNombre_TextChanged(object sender, EventArgs e)
		{
			//actualizo label cuando el texto ha sido cambiado. Se dispara al salir de la caja de texto.
			//si tiene updatepanel como ahora, Y con autopostback en true, se actualiza al salir de la caja.
			//SINO, se actualiza al realizarse algun postbback, por ejemplo un click en un boton.
			lblNombre.Text = txtNombre.Text;
		}

		protected void btnAceptar_Click(object sender, EventArgs e)
		{
			//evento normal de click, tira postback. Actualiza la caja de texto.
			//en este caso esta dentro de un update panel por eso solo actualiza eso.
			txtNombre.Text = "texto cambiado desde el back";
		}

		protected void ddlTipos_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = int.Parse(ddlTipos.SelectedItem.Value);
			ddlPokemonsFiltrados.DataSource = ((List<Pokemon>)Session["listaPokemon"]).FindAll(x => x.Tipo.Id == id);
			ddlPokemonsFiltrados.DataBind();	
		}

		protected void btnSeleccionar_Click(object sender, EventArgs e)
		{
			string id = txtIdTipo.Text;
			//ddlTipoPreseleccionado.Items.FindByValue(id).Selected = true;

			ddlTipoPreseleccionado.SelectedIndex = ddlTipoPreseleccionado.Items.IndexOf(
				ddlTipoPreseleccionado.Items.FindByValue(id));
		}

		protected void Cargar_Click(object sender, EventArgs e)
		{
			urlImagen = txtUrlImagen.Text;
		}
	}
}