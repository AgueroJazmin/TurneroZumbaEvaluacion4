using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TurneroZumba.BA;

namespace TurneroZumba.BA
{
    public class Turno
    {
        public Alumno Alumno { get; set; }
        public string DNI { get; set; }
        public string Dia { get; set; }
        public string TurnoDelDia { get; set; }
        public string Horario { get; set; }

        public Turno(Alumno alumno, string dni, string dia, string turnoDelDia, string horario)
        {
            Alumno = alumno;
            DNI = dni;
            Dia = dia;
            TurnoDelDia = turnoDelDia;
            Horario = horario;
        }

        public Turno(Alumno alumno, string dia, string turnoDelDia, string horario)
        {
            Alumno = alumno;
            Dia = dia;
            TurnoDelDia = turnoDelDia;
            Horario = horario;
        }

        public override string ToString()
        {
            return $"{DNI} - {Alumno} - {Dia} - {TurnoDelDia} - {Horario}";
        }
    }
}

