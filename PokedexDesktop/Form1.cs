﻿using System;
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
        private List<Pokemon> lista;

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
            // List<Pokemon> lista;

            try
            {
                //lista = negocio.listar();
                lista = negocio.listarConView();
                dgvListadoPOKEMONS.DataSource = lista;
                dgvListadoPOKEMONS.Columns[0].Visible = false;
                // dgvListadoPOKEMONS.Columns[4].Visible = false;


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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon modificar;
            modificar = (Pokemon)dgvListadoPOKEMONS.CurrentRow.DataBoundItem;
            frmAltaPokemon frmModificar = new frmAltaPokemon(modificar);
            // frmModificar.Text = "Modificar";
            frmModificar.ShowDialog();
            cargarDatos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                int id = ((Pokemon)dgvListadoPOKEMONS.CurrentRow.DataBoundItem).Id;
                negocio.eliminarLogico(id);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lista.Count().ToString());
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            try
            {
                if (txtBusqueda.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(k => k.Descripcion.ToLower().Contains(txtBusqueda.Text.ToLower()) || k.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower()) || (k.Evolucion != null ? k.Evolucion.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower()) : k.Nombre.Contains("")));
                }
                dgvListadoPOKEMONS.DataSource = listaFiltrada;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
