namespace ColeccionLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> ListaPersona = new List<Persona>();


        private void btnTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = ListaPersona.Count().ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona Instancia = new Persona()
            {
                Id = int.Parse(txtId.Text),
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Telefono = int.Parse(txtTelefonos.Text),
                Salario = double.Parse(txtSalarios.Text)
            };

            ListaPersona.Add(Instancia);

            MessageBox.Show(Instancia.Nombres + " se ha agregado");

            dgvPersonas.DataSource = "null";
            dgvPersonas.DataSource = ListaPersona;
            dgvPersonas.Refresh();

            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefonos.Clear();
            txtSalarios.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var Consulta = (from elemento in ListaPersona
                            where elemento.Id == int.Parse(txtId.Text)
                            select new
                            {
                                elemento.Nombres,
                                elemento.Apellidos
                            }).ToList();



            dgvPersonas.DataSource = Consulta;
            dgvPersonas.Refresh();
        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            var Consulta = (from elemento in ListaPersona where elemento.Salario > 
                            1000 select new { elemento.Nombres, elemento.Apellidos, 
                                elemento.Salario }).ToList();

            dgvPersonas.DataSource = "null";
            dgvPersonas.DataSource = Consulta;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = ListaPersona;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            lblPromedio.Text = ListaPersona.Average(p => p.Salario).ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            lblSuma.Text = Math.Round(ListaPersona.Sum(p => p.Salario),2).ToString();
        }
    }
}