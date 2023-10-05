using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace RutaDeAcceso
{
    public partial class Form1 : Form
    {
        
        Stack<String> NombresCarpetas = new Stack<string>();
        Stack<String> RutasDeAcceso = new Stack<string>();
        int CantidadDeCarpetas;

       
        public Form1()
        { InitializeComponent(); }

        /*Funciones del panel Nueva Carpeta.*/
        private void txtNuevaCarpeta_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) btnAgregarCarpeta_Click(sender, e); }

        private void btnAgregarCarpeta_Click(object sender, EventArgs e)
        {
            if (txtNuevaCarpeta.Text.Trim() == "")
                MessageBox.Show("Ingrese un nombre valido.");
            else
            {
                NombresCarpetas.Push(txtNuevaCarpeta.Text.Trim());
                CantidadDeCarpetas = NombresCarpetas.Count();
                MostrarCarpetas();
                txtNuevaCarpeta.Clear();
            }
        }


        private void txtRuta_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) btnAbrir_Click_1(sender, e); }


        private void btnAbrir_Click_1(object sender, EventArgs e)
        {
            if (cbRutas.SelectedItem != null)
            {
                // Obtén la ruta seleccionada en el ComboBox.
                string rutaSeleccionada = cbRutas.SelectedItem.ToString();

                // Divide la ruta en partes utilizando "\\" como separador.
                string[] partesRuta = rutaSeleccionada.Split('\\');

                // Verifica si hay al menos una parte en la ruta.
                if (partesRuta.Length > 0)
                {
                    // Obtiene la última parte de la ruta (nombre de la carpeta).
                    string ultimaCarpeta = partesRuta[partesRuta.Length - 1];

                    // Concatena el texto deseado con el nombre de la carpeta.
                    string textoConcatenado = "Carpeta Abierta: " + ultimaCarpeta;

                    // Asigna el texto concatenado al cuadro de texto txtRutaImpresa.
                    txtRutaImpresa.Text = textoConcatenado;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna ruta.");
            }
        }


        /*
        Función que crear una carpetita(imagen) 
        para la nueva carpeta en la pila.
        */
        public void MostrarCarpetas()
        {
            var Titulo = new Label();
            Titulo.Visible = true;
            Titulo.Size = new System.Drawing.Size(227, 20);
            Titulo.Text = "Directorio";
            Titulo.TextAlign = ContentAlignment.TopCenter;
            Titulo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Titulo.BackColor = Color.Blue;
            Titulo.ForeColor = Color.White;
            Titulo.Location = new System.Drawing.Point(0, 0);

            /*Ubicación y tamaño de la primera carpeta.*/
            int x_locacion = 14, y_locacion = 28,
                  x_tamaño = 25, y_tamaño = 30;
            panel3.Controls.Clear();
            panel3.Controls.Add(Titulo);
            for (int indice = (CantidadDeCarpetas - 1); indice > -1; indice--)
            {
                var imagen = new PictureBox();/*Para la carpetita.*/
                imagen.Visible = true;
                imagen.Image = Properties.Resources.Carpetita;
                imagen.SizeMode = PictureBoxSizeMode.Zoom;
                imagen.Size = new System.Drawing.Size(x_tamaño, y_tamaño);
                imagen.Location = new System.Drawing.Point(x_locacion, y_locacion);

                
                var etiqueta = new Label();/*Para el nombre.*/
                etiqueta.Visible = true;
                etiqueta.AutoSize = true;
                etiqueta.Text = NombresCarpetas.ElementAt(indice);
                etiqueta.ForeColor = Color.Blue;
                etiqueta.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                etiqueta.Location = new System.Drawing.Point(x_locacion + 30, y_locacion + 7);

                panel3.Controls.Add(imagen);
                panel3.Controls.Add(etiqueta);

                x_locacion += 31;
                y_locacion += 36;
            }
            MostrarRutas();
        }
 
       

        /*Devuelve la ruta, el nombre*/
        public string Busqueda(string Dato)
        {
            string resultado = null;
            for (int j = 0; j < CantidadDeCarpetas; j++)
            {
                if (string.Equals(RutasDeAcceso.ElementAt(j), Dato))
                { resultado = NombresCarpetas.ElementAt(j); break; }
            }
            for (int j = 0; j < CantidadDeCarpetas; j++)
            {
                if (string.Equals(NombresCarpetas.ElementAt(j), Dato))
                { resultado = RutasDeAcceso.ElementAt(j); break; }
            }
            return resultado;
        }

        /*Le asigna la elección del ComboBox a txtRuta.*/
        private void cbRutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRuta.Text = cbRutas.Text;
            cbRutas.Text = "";
        }
        /*Muestra las direcciones de cada carpeta en el ComboBox.*/
        void MostrarRutas()
        {
            cbRutas.Items.Clear();
            if (CantidadDeCarpetas > 0)
            {
                string cadena = NombresCarpetas.ElementAt(CantidadDeCarpetas - 1);
                cbRutas.Items.Add(cadena + "\\");
                RutasDeAcceso.Push(cadena + "\\");
                for (int indice = (CantidadDeCarpetas - 2); indice > -1; indice--)
                {
                    cadena += "\\" + NombresCarpetas.ElementAt(indice);

                    RutasDeAcceso.Push(cadena);
                    cbRutas.Items.Add(cadena);
                }
            }
        }
        
        private void txtRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
