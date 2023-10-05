using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        Queue<string> ColaEstudiante = new Queue<string>();

        void Imprimir()
        {
            lbEstudiante.Items.Clear();

            foreach (var carnet in ColaEstudiante)
                lbEstudiante.Items.Add(carnet);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (var estudiante in Declaraciones.Estudiantes)
            {
                if (estudiante.Carnet == txtCarnet.Text)
                {
                    MessageBox.Show("Se ha agregado a la cola el estudiante" + estudiante.Nombre + "" + estudiante.Apellido);
                    ColaEstudiante.Enqueue(estudiante.Carnet);
                    Imprimir();
                    return;

                }
            }
            MessageBox.Show("No se ha encontrado el estudiante");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            foreach (var estudiante in Declaraciones.Estudiantes)
            {
                if (estudiante.Carnet == ColaEstudiante.Peek())
                {
                    lbCarnet.Text = estudiante.Carnet;
                    lbNombre.Text = estudiante.Nombre;
                    lbApellido.Text = estudiante.Apellido;
                    lbEdad.Text = estudiante.Edad.ToString();

                    break;
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            lbCarnet.Text = lbNombre.Text = lbApellido.Text = lbEdad.Text;

        }
    }
}
