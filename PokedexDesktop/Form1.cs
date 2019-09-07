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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            List<Pokemon> lista;
            try
            {
                lista = negocio.listar();
                dgvListadoPokemones.DataSource = lista;
                dgvListadoPokemones.Columns[0].Visible = false;
                // dgvListadoPokemones.Columns[4].Visible = false;


                // MessageBox.Show(lista[0].Tipo.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
            cargarDatos();
        }
    }
}
