using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
namespace LAB2_E1
{
    internal class CasaComercial
    {
        public int Id { get; set; }
        public int Deuda { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string EdD (int a)
        {
            if (a == 0)
                return "Pagada";
            else
                return "No pagada";
        }
        public string Imprimir()
        {
            return Id + "\t" + Deuda + "\t" + Nombre + "\t" + Direccion + "\t" + Telefono;
        }

    }

}
