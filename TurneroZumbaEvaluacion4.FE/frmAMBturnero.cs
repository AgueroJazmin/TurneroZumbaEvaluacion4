using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurneroZumba.BA;

namespace TurneroZumbaEvaluacion4.FE
{
    public partial class frmAMBturnero : Form
    {
        private Turnero turnero;
        public frmAMBturnero()
        {
            InitializeComponent();
            turnero = new Turnero();
            cbDias.Items.Add("Martes");
            cbDias.Items.Add("Jueves");
            cbTurnos.Items.Add("Mañana");
            cbTurnos.Items.Add("Tarde");
            cbTurnos.Items.Add("Noche");

            DGV.DataSource = turnero.ObtenerTurnos();
        }
        private void cbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHorarios.Items.Clear(); 

            string turnoSeleccionado = cbTurnos.SelectedItem?.ToString();
            if (turnoSeleccionado == null)
            {
                return; 
            }

            if (turnoSeleccionado == "Mañana")
            {
                cbHorarios.Items.Add("08:30");
                cbHorarios.Items.Add("09:30");
            }
            else if (turnoSeleccionado == "Tarde")
            {
                cbHorarios.Items.Add("16:30");
                cbHorarios.Items.Add("17:30");
            }
            else if (turnoSeleccionado == "Noche")
            {
                cbHorarios.Items.Add("19:30");
                cbHorarios.Items.Add("20:30");
            }
        }

        private void btmAgendar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string dni = txtDNI.Text;
            string dia = cbDias.SelectedItem?.ToString();
            string turnoDelDia = cbTurnos.SelectedItem?.ToString();
            string horario = cbHorarios.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrEmpty(dia) || string.IsNullOrEmpty(turnoDelDia) || string.IsNullOrEmpty(horario))
            {
                MessageBox.Show("Por favor, complete todos los datos.");
                return;
            }

            Alumno alumno = new Alumno(nombre, dni);
            bool agendado = turnero.AgendarTurno(alumno, dia, turnoDelDia, horario);

            if (agendado)
            {
                MessageBox.Show($"{nombre} has agendado un turno para el {dia} en {turnoDelDia} a las {horario}");
            }
            else
            {
                MessageBox.Show("El turno ya está ocupado.");
            }

            LimpiarTxt();
            ActualizarDGV();
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string dia = cbDias.SelectedItem?.ToString();
            string horario = cbHorarios.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrEmpty(dia) || string.IsNullOrEmpty(horario))
            {
                MessageBox.Show("Por favor, complete todos los datos.");
                return;
            }

            bool cancelado = turnero.CancelarTurno(dni, dia, horario);

            if (cancelado)
            {
                MessageBox.Show("Turno cancelado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró el turno especificado.");
            }

            LimpiarTxt();
            ActualizarDGV();
        }

        private void ActualizarDGV()
        {
            DGV.DataSource = turnero.ObtenerTurnos();
        }

        private void LimpiarTxt()
        {
            txtNombre.Text = "";
            txtDNI.Text = "";
            cbDias.SelectedIndex = -1;
            cbTurnos.SelectedIndex = -1;
            cbHorarios.Items.Clear();
            txtNombre.Focus();
        }

        private void lblSalida_Click(object sender, EventArgs e)
        {

        }
    }
}
