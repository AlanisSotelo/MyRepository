using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta
{
    internal class Estudiante
    {
        public String Carnet { get; set; }
        public String Nombre { get; set;}
        public String Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - FechaNacimiento.Year;
            }
        }

        public Estudiante ( string carnet, string nombre, string apellido , 
            DateTime fechaNacimiento)
            {
            Carnet = carnet;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;


        }
    }
}
