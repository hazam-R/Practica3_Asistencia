using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winMySQL.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica3_Asistencia.Forms
{
    public partial class frmHistorial : Form
    {
        Datos datos = new Datos();
        string nocontrol;
        public frmHistorial(string nocontrol)
        {
            InitializeComponent();
            this.nocontrol = nocontrol;
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            // Mostrar nombre del alumno en un label
            DataSet dsAlumno = datos.ejecutar(
                $"SELECT nombre, paterno, materno FROM Alumnos " +
                $"WHERE nocontrol = '{nocontrol}'");

            if (dsAlumno != null)
            {
                DataRow fila = dsAlumno.Tables[0].Rows[0];
                lblNombre.Text = fila["nombre"].ToString() + " " +
                                 fila["paterno"].ToString() + " " +
                                 fila["materno"].ToString();
            }

            // Cargar historial de asistencias
            DataSet dsHistorial = datos.ejecutar(
                $"SELECT fecha, " +
                $"CASE WHEN asistencia = 1 THEN 'Asistió' ELSE 'Faltó' END AS estado " +
                $"FROM Asitencia " +
                $"WHERE nocontrol = '{nocontrol}' " +
                $"ORDER BY fecha DESC");

            if (dsHistorial != null)
            {
                dgvHistorial.DataSource = dsHistorial.Tables[0];
            }
        }
    }

}
