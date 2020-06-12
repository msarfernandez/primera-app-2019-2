using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;


namespace PokedexDesktop
{
    public partial class frmAltaPokemon : Form
    {
        private Pokemon pokemon = null;

        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            TipoNegocio tipoNegocio = new TipoNegocio();
            try
            {
                cboEvolucion.DataSource = negocio.listar();
                cboEvolucion.ValueMember = "Id";
                cboEvolucion.DisplayMember = "Nombre";
                cboEvolucion.SelectedIndex = -1;

                cboTipo.DataSource = tipoNegocio.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboTipo.SelectedIndex = -1;

                if(pokemon != null)
                {
                    Text = "Modificar";
                    txtNombre.Text = pokemon.Nombre;
                    txtDesc.Text = pokemon.Descripcion;
                    if (pokemon.Evolucion != null)
                        cboEvolucion.SelectedValue = pokemon.Evolucion.Id;

                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();

            // lo comento porque puede venir de afuera... y es un atributo del form
            //Pokemon pokemon = new Pokemon();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDesc.Text;
                pokemon.Tipo = (Tipo)cboTipo.SelectedItem;
                pokemon.Evolucion = (Pokemon)cboEvolucion.SelectedItem;

                // pokemon.Evolucion = new Pokemon();
                // pokemon.Evolucion.Id = (int)cboEvolucion.SelectedValue;

                if(pokemon.Id != 0)
                    pokemonNegocio.modificar(pokemon);
                else
                    pokemonNegocio.agregarConSP(pokemon);

                Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
