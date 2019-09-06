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
    public partial class frmEjemplosClases : Form
    {
        public frmEjemplosClases()
        {
            InitializeComponent();
        }

        private void frmEjemplosClases_Load(object sender, EventArgs e)
        {
            try
            {
                //Alumno alu;
                Mascota prueba8;
                prueba8 = new Gato();
                Mascota m1 = new Mascota();
                m1.Color = "Rojo";
                // MessageBox.Show("La mascota dice: " + m1.comunicarse());

                Perro p1 = new Perro();
                Gato g1 = new Gato();

                // MessageBox.Show("El perro dice: " + p1.comunicarse() + "\n\r" + "El gato dice: " + g1.comunicarse());
                //alu = p1; ESTO NO SE PUEDE
                p1.TipoPerro = "lindo";
                m1 = p1;
                // MessageBox.Show(m1.comunicarse());

                Perro p2 = null;
                p2 = (Perro)m1;
                // MessageBox.Show( p2.comunicarse());

                // creamos una colección de mascotas (lo que antes conocíamos como vector, pero ahora es mágique)
                List<Mascota> listaMascotas = new List<Mascota>();
                listaMascotas.Add(new Gato());
                listaMascotas.Add(new Gato());
                listaMascotas.Add(new Mascota());
                listaMascotas.Add(m1);
                listaMascotas.Add(p1);
                listaMascotas.Add(g1);

                // luego de cargarle varios objetos de "la familia", recorremos la colección con el ForEach (mágique too)
                foreach (Mascota mascota in listaMascotas)
                {
                    MessageBox.Show(mascota.comunicarse());
                }

                for (int i = 0; i < listaMascotas.Count -1; i++)
                {
                    var mascota = listaMascotas[i];
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        Mascota buscar(List<Mascota> lista, string color)
        {
            foreach (Mascota item in lista)
            {
                if(item.Color == color || color == "Rojo")
                {
                    return item;
                }
            }
                    return new Mascota();
        }
    }
}
