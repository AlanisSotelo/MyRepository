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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Array.Resize(ref Declaraciones.Estudiantes, Declaraciones.N + 1);

            Estudiante estudiante = new Estudiante(txtCarnet.Text, txtNombre.Text,
                txtApellido.Text, dtFecha.Value);

            Declaraciones.Estudiantes[Declaraciones.N] = estudiante;
            Declaraciones.N++;

            dgListado.DataSource = Declaraciones.Estudiantes;
            dgListado.Refresh();
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
