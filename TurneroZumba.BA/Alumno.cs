using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurneroZumba.BA
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }

        public Alumno(string nombre, string dni)
        {
            Nombre = nombre;
            DNI = dni;
        }
    }
}
