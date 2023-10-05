using System.Data;

namespace EntregaEstudiantes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        // Declaraciones globales para los arreglos y el contador
        Entrega[] entregas;
        int N;
        int a;

        void Imprimir()
        {
            dgElementos.DataSource = null;
            dgElementos.DataSource = entregas;
        }
        void Limpiar()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtCarnet.Clear();
            txtProyecto.Clear();
            txtCalificacion.Clear();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private int BuscarPosicionInsercion(Entrega nuevaEntrega)
        {
            int posicionInsercion = 0;
            while (posicionInsercion < N && nuevaEntrega.FechaEntrega > entregas[posicionInsercion].FechaEntrega)
            {
                posicionInsercion++;
            }

            // Si se encontró una coincidencia, devuelve -1 para indicar que el elemento ya existe
            if (posicionInsercion < N && nuevaEntrega.FechaEntrega == entregas[posicionInsercion].FechaEntrega)
            {
                return -1;
            }


            return posicionInsercion;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Crear una nueva entrega con los datos ingresados
            Entrega nuevaEntrega = new Entrega(txtCarnet.Text, txtNombre.Text, txtApellido.Text, txtProyecto.Text, DateTime.Parse(dtFechaLim.Text), DateTime.Parse(dtFechaEntrega.Text), int.Parse(txtCalificacion.Text));

            // Encontrar la posición donde se debe insertar la nueva entrega
            int posicionInsercion = 0;
            while (posicionInsercion < N && nuevaEntrega.FechaEntrega > entregas[posicionInsercion].FechaEntrega)
            {
                posicionInsercion++;
            }

            // Desplazar elementos para hacer espacio para la nueva entrega
            Array.Resize(ref entregas, N + 1);
            for (int i = N; i > posicionInsercion; i--)
            {
                entregas[i] = entregas[i - 1];
            }

            // Insertar la nueva entrega en la posición adecuada
            entregas[posicionInsercion] = nuevaEntrega;
            N++;

            // Actualizar la visualización y limpiar los campos
            Imprimir();
            Limpiar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dgElementos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            txtCarnet.Text = dgElementos.Rows[a].Cells[0].Value.ToString();
            txtNombre.Text = dgElementos.Rows[a].Cells[1].Value.ToString();
            txtApellido.Text = dgElementos.Rows[a].Cells[2].Value.ToString();
            txtProyecto.Text = dgElementos.Rows[a].Cells[3].Value.ToString();
            dtFechaLim.Text = dgElementos.Rows[a].Cells[4].Value.ToString();
            dtFechaEntrega.Text = dgElementos.Rows[a].Cells[5].Value.ToString();
            txtCalificacion.Text = dgElementos.Rows[a].Cells[6].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (a >= 0 && a < N)
            {
                string carnetAEliminar = entregas[a].Carnet;

                // Encuentra la posición del elemento a eliminar en función del número de carnet
                int posicionEliminar = -1;
                for (int i = 0; i < N; i++)
                {
                    if (entregas[i].Carnet == carnetAEliminar)
                    {
                        posicionEliminar = i;
                        break; // Salir del bucle una vez que se encuentre la coincidencia
                    }


                }

                if (posicionEliminar >= 0)
                {
                    // Mueve los elementos posteriores un lugar hacia atrás
                    for (int k = posicionEliminar; k < N - 1; k++)
                    {
                        entregas[k] = entregas[k + 1];
                    }

                    N--;
                    Array.Resize(ref entregas, N);
                    Imprimir();
                    Limpiar();
                }

            }
            else
            {
                MessageBox.Show("Selecciona una fila válida para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            entregas[a].Carnet = txtCarnet.Text;
            entregas[a].Nombre = txtNombre.Text;
            entregas[a].Apellido = txtApellido.Text;
            entregas[a].Proyecto = txtProyecto.Text;
            entregas[a].FechaLimite = DateTime.Parse(dtFechaLim.Text);
            entregas[a].FechaEntrega = DateTime.Parse(dtFechaEntrega.Text);
            entregas[a].Calificacion = int.Parse(txtCalificacion.Text);
            Array.Resize(ref entregas, N);
            Imprimir();
            Limpiar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Limpiar();
            string carnetABuscar = txtCarnet.Text;

            int posicionListar = BuscarPosicionInsercion(new Entrega("", carnetABuscar, "", "", DateTime.Now, DateTime.Now, 0));

            if (posicionListar != -1)
            {
                // Limpia el DataGridView antes de listar el elemento
                dgElementos.DataSource = null;

                // Crea un arreglo de una sola entrega con el elemento a listar
                Entrega[] entregaListada = new Entrega[] { entregas[posicionListar] };

                // Asigna el arreglo al DataGridView para mostrar el elemento
                dgElementos.DataSource = entregaListada;
            }
            else
            {
                MessageBox.Show("No se encontró la entrega con el número de carnet especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnEntrgasTardias_Click(object sender, EventArgs e)
        {
            // Obtén la fecha límite a partir del DateTimePicker
            DateTime fechaLimite = DateTime.Parse(dtFechaLim.Text);

            // Filtra las entregas tardías en un nuevo arreglo
            Entrega[] entregasTardias = entregas
                .Where(entrega => entrega.FechaEntrega > fechaLimite && entrega.FechaEntrega.Date != fechaLimite.Date)
                .ToArray();

            // Limpia el DataGridView antes de mostrar las entregas tardías
            dgElementos.DataSource = null;

            // Asigna el arreglo de entregas tardías al DataGridView
            dgElementos.DataSource = entregasTardias;
        }
    }
}