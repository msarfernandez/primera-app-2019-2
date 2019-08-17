using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        private int vecesQuePasastePorHover = 0;
        bool banderaVentana = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            int miVariable = 8;
            MessageBox.Show("Hola Mundo " + miVariable);
            miMetodo();
        }

        private void miMetodo()
        {
            MessageBox.Show("No hace nada...");
        }

        private void OtroMetodo()
        {
            miMetodo();
        }


        private void btnOtroBoton_Click(object sender, EventArgs e)
        {
            // miMetodo();
            if (cbxPasaje.Checked)
            {
                frmVentanaDos ventana = new frmVentanaDos();
                Hide();// oculto la ventana actual.
                ventana.ShowDialog();
                Show();// muestro la ventana actual.

            }
            else
            {
                MessageBox.Show("Debe aceptar los términos y condiciones antes de continuar...");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaludar_MouseHover(object sender, EventArgs e)
        {
            vecesQuePasastePorHover++;
            btnSaludar.Text = "HODOR " + vecesQuePasastePorHover;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por participar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboOpciones.Items.Add("Azul");
            cboOpciones.Items.Add("Verde");
            cboOpciones.Items.Add("Rojo");
            cboOpciones.Items.Add("Amarelo");
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboOpciones.Text)
            {
                case "Azul":
                    BackColor = Color.Blue;
                    break;
                case "Verde":
                    BackColor = Color.Green;
                    break;
                case "Rojo":
                    BackColor = Color.Red;
                    break;
                case "Amarelo":
                    BackColor = Color.YellowGreen;
                    break;

                default:
                    break;
            }
        }

        private void btnCambiarLugares_Click(object sender, EventArgs e)
        {
            var x = btnSaludar.Location;
            btnSaludar.Location = btnCambiarLugares.Location;
            btnCambiarLugares.Location = x;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
