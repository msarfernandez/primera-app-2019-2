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
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            TipoNegocio tipoNegocio = new TipoNegocio();
            try
            {
                cboEvolucion.DataSource = negocio.listar();
                cboTipo.DataSource = tipoNegocio.listar();
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
            Pokemon pokemon = new Pokemon();
            try
            {
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDesc.Text;
                pokemon.Tipo = (Tipo)cboTipo.SelectedItem;
                pokemon.Evolucion = (Pokemon)cboEvolucion.SelectedItem;

                pokemonNegocio.agregar(pokemon);
                Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
