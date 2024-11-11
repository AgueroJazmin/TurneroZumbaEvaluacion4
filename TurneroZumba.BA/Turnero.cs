using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurneroZumba.BA;

namespace TurneroZumba.BA
{
    public class Turnero
    {
        private List<Turno> turnos;
        private DataTable tablaTurnos;

        public Turnero()
        {
            tablaTurnos = new DataTable();
            tablaTurnos.TableName = "Turnos";
            tablaTurnos.Columns.Add("DNI");
            tablaTurnos.Columns.Add("Nombre");
            tablaTurnos.Columns.Add("Dia");
            tablaTurnos.Columns.Add("TurnoDelDia");
            tablaTurnos.Columns.Add("Horario");

            LeerArchivo();
        }

        private void LeerArchivo()
        {
            if (System.IO.File.Exists("Turnos.xml"))
            {
                tablaTurnos.ReadXml("Turnos.xml");
            }
        }

        private void GuardarArchivo()
        {
            tablaTurnos.WriteXml("Turnos.xml");
        }

        public bool AgendarTurno(Alumno alumno, string dia, string turnoDelDia, string horario)
        {
            DataRow[] turnosExistentes = tablaTurnos.Select($"Dia = '{dia}' AND Horario = '{horario}'");
            if (turnosExistentes.Length > 0)
            {
                return false; // El turno ya está ocupado
            }

            DataRow nuevoTurno = tablaTurnos.NewRow();
            nuevoTurno["DNI"] = alumno.DNI;
            nuevoTurno["Nombre"] = alumno.Nombre;
            nuevoTurno["Dia"] = dia;
            nuevoTurno["TurnoDelDia"] = turnoDelDia;
            nuevoTurno["Horario"] = horario;
            tablaTurnos.Rows.Add(nuevoTurno);

            GuardarArchivo();
            return true;
        }

        public bool CancelarTurno(string dni, string dia, string horario)
        {
            DataRow[] turnos = tablaTurnos.Select($"DNI = '{dni}' AND Dia = '{dia}' AND Horario = '{horario}'");
            if (turnos.Length > 0)
            {
                tablaTurnos.Rows.Remove(turnos[0]);
                GuardarArchivo();
                return true;
            }
            return false;
        }

        public DataTable ObtenerTurnos()
        {
            return tablaTurnos;
        }
    }
}
