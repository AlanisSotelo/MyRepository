using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaEstudiantes
{
    internal class Entrega
    {
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Proyecto { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaLimite { get; set; }
        public int Calificacion { get; set; }

        public Entrega(string carnet, string nombre, string apellido, string proyecto, DateTime fechaEntrega, DateTime fechaLimite, int calificacion)
        {
            Carnet = carnet;
            Nombre = nombre;
            Apellido = apellido;
            Proyecto = proyecto;
            FechaEntrega = fechaEntrega;
            FechaLimite = fechaLimite;
            Calificacion = calificacion;
        }

    }
}
