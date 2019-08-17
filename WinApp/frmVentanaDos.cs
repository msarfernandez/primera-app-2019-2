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
    public partial class frmVentanaDos : Form
    {
        public frmVentanaDos()
        {
            InitializeComponent();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(dividir(int.Parse(txtNro1.Text),
                    int.Parse(txtNro2.Text)).ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Los datos ingresados son incorrectos.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dvidir por cero.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private double dividir(int a, int b)
        {
            return a / b;
        }

        private void btnProbarEx_Click(object sender, EventArgs e)
        {
            try
            {
                throw new MiException();
            }
            catch (MiException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
