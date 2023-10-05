using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaraciones Globales
        CasaComercial[] Instancia;
        
        int Tam, N = 0, i, Pos, x, x2;

        void Limpiar()
        {
            txtId.Clear();
            txtDeuda.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtId.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public int Buscar(int x)
        {
            i = 0;
            while (i < N && Instancia[i].Id < x)
            {
                i = i + 1;
            }
            if (i >= N || Instancia[i].Id < x)
            {
                Pos = -i;
            }
            else
            {
                Pos = i;
            }
            return Pos;
        }
        void Eliminar(int x)
        {
            if (N > 0)
            {
                Pos = Buscar(x);
                MessageBox.Show(x + Pos.ToString());
                if (Pos <= -1)
                {
                    MessageBox.Show("La persona con el Id: " + x + " no se encuentra registrada");
                }
                else
                {
                    for (i = Pos; i < N - 1; i++)
                    {
                        Instancia[i].Id = Instancia[i + 1].Id;
                        Instancia[i].Deuda = Instancia[i + 1].Deuda;
                        Instancia[i].Nombre = Instancia[i + 1].Nombre;
                        Instancia[i].Direccion = Instancia[i + 1].Direccion;
                        Instancia[i].Telefono = Instancia[i + 1].Telefono;
                    }
                    N = N - 1;
                    MessageBox.Show("La persona con el Id: " + x + " se ha eliminado");
                }
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        void Insertar(int x)
        {
            if (N > 0)
            {
                if (N <= Tam - 1)
                {
                    Pos = Buscar(x);
                    if (Pos > 0)
                    {
                        MessageBox.Show("El elemento ya existe");
                    }
                    else
                    {
                        Pos = Pos * -1;
                        for (i = N; i >= Pos +1; i--)
                        {
                            Instancia[i] = new CasaComercial();
                            Instancia[i].Id = Instancia[i - 1].Id;
                            Instancia[i].Deuda = Instancia[i - 1].Deuda;
                            Instancia[i].Nombre = Instancia[i - 1].Nombre;
                            Instancia[i].Direccion = Instancia[i - 1].Direccion;
                            Instancia[i].Telefono = Instancia[i - 1].Telefono;

                        }

                        Instancia[Pos] = new CasaComercial();
                        Instancia[Pos].Id = int.Parse(txtId.Text);
                        Instancia[Pos].Deuda = int.Parse(txtDeuda.Text);
                        Instancia[Pos].Nombre = txtNombre.Text;
                        Instancia[Pos].Direccion = txtDireccion.Text;
                        Instancia[Pos].Telefono = int.Parse(txtTelefono.Text);
                        N = N + 1;
                        MessageBox.Show("Persona Insertada");
                    }
                }
                else
                {
                    MessageBox.Show("No hay espacio");
                }
            }
            else
            {

                Instancia[N] = new CasaComercial();
                Instancia[N].Id = int.Parse(txtId.Text);
                Instancia[N].Deuda = int.Parse(txtDeuda.Text);
                Instancia[N].Nombre = txtNombre.Text;
                Instancia[N].Direccion = txtDireccion.Text;
                Instancia[N].Telefono = int.Parse(txtTelefono.Text);
                N = N + 1;
                MessageBox.Show("Persona Insertada");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            for (i = 0; i < N; i++)
            {
                string E = Instancia[i].EdD(Instancia[i].Deuda);
                lbImprimir.Items.Add(Instancia[i].Imprimir() + "\t" + E);

            }
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            string x = txtId.Text;


            if (N < 0)
            {
                Pos = Buscar(int.Parse(x));
                if (Pos <= -1)
                {
                    MessageBox.Show("Persona no registrada");
                }
                else
                {
                    for (i = Pos; i < N - 1; i++)
                    {
                        string E = Instancia[i].EdD(Instancia[i].Deuda);
                        lbImprimir.Items.Add(Instancia[i].Imprimir() + "\t" + E);
                    }
                }
            }
            else
            {
                MessageBox.Show("Persona no registrada");
            }
            


        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            Tam = int.Parse(txtEstablecer.Text);
            Instancia = new CasaComercial[Tam];
            N = 0;

        }

        private void brnBuscar_Click(object sender, EventArgs e)
        {
            if (N > 0)
            {
                x2 = int.Parse(txtId.Text);
                Pos = Buscar(x2);
                if (Pos <= -1)
                {
                    MessageBox.Show("La persona con el Id: " + x2 + " no esta registrada");
                }
                else
                {
                    txtDeuda.Text = Convert.ToString(Instancia[Pos].Deuda);
                    txtNombre.Text = Instancia[Pos].Nombre;
                    txtDireccion.Text = Instancia[Pos].Direccion;
                    txtTelefono.Text = Convert.ToString(Instancia[Pos].Telefono);
                }
            }
            else
            {
                MessageBox.Show("No hay registros");
            }

        }

        private void txtEdD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtId.Text);
            Eliminar(x);
            Limpiar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtId.Text);
            Insertar(x);
            Limpiar();
        }
    }
}
