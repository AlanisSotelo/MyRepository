using System.Xml.Serialization;

namespace Consulta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FrmConsultas formularioConsultas;
        FrmEstudiante formularioEstudiante;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            formularioConsultas = new FrmConsultas()
            {
                TopLevel = false,
                Parent = this,
                FormBorderStyle = FormBorderStyle.None,
                Location = new Point(0, menuStrip1.Height)


            };

            formularioEstudiante = new FrmEstudiante()
            {
                TopLevel = false,
                Parent = this,
                FormBorderStyle = FormBorderStyle.None,
                Location = new Point(0, menuStrip1.Height)

            };
        }



    }
}