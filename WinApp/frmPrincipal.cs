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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPrimerosEjemplos_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmVentanaDos excepciones = new frmVentanaDos();
            excepciones.MdiParent = this;
            excepciones.Show();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmEjemplosClases ventana = new frmEjemplosClases();
            ventana.Show();
        }
    }
}
