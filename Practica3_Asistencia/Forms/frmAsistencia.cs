using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winMySQL.Clases;

namespace Practica3_Asistencia.Forms
{
    public partial class frmAsistencia : Form
    {
        DataTable tablaAlumnos;
        Datos datos = new Datos();
        int indice = 0;

        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            //Limpiar todo antes de volver a cargar
            dgvAlumnos.DataSource = null;
            dgvAlumnos.Columns.Clear();

            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");



            // Trae alumnos y si ya tienen registro ese día
            DataSet ds = datos.ejecutar(
                "SELECT a.nocontrol, a.nombre, a.paterno, a.materno, " +
                "asi.asistencia " +
                "FROM Alumnos a " +
                "LEFT JOIN Asitencia asi ON a.nocontrol = asi.nocontrol " +
                $"AND asi.fecha = '{fecha}' " +
                "ORDER BY a.nocontrol");

            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];

                // Ocultar la columna asistencia del dataset
                dgvAlumnos.Columns["asistencia"].Visible = false;

                // Agregar columna checkbox de manera virtual a la base de datos para contar la asistencia
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.Name = "chkAsistencia";
                chk.HeaderText = "Asistencia";
                chk.TrueValue = true;
                chk.FalseValue = false;
                dgvAlumnos.Columns.Add(chk);

                // Llenar checkboxes según lo que ya hay en BD en caso de que haya regstros
                foreach (DataGridViewRow fila in dgvAlumnos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    // Si asistencia es null significa que no hay registro ese día
                    if (fila.Cells["asistencia"].Value != DBNull.Value)
                    {
                        fila.Cells["chkAsistencia"].Value = Convert.ToBoolean(fila.Cells["asistencia"].Value);
                    }
                    else
                    {
                        fila.Cells["chkAsistencia"].Value = false;
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            //Construirun solo INSERT con todos los registros
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("INSERT INTO Asitencia (nocontrol,fecha,asistencia) VALUES ");

            //lista para agregar todos los alumnos
            List<string> valores = new List<string>();

            foreach (DataGridViewRow fila in dgvAlumnos.Rows)
            {
                //No toma en cuenta el ultimo renglon que se agrega en los data grid view
                if (fila.IsNewRow) continue;

                string nocontrol = fila.Cells["nocontrol"].Value.ToString();
                bool asistio = Convert.ToBoolean(fila.Cells["chkAsistencia"].Value);
                int asistencia = asistio ? 1 : 0;

                // Si ya existe el registro lo actualiza, si no lo inserta
                //datos.ejecutarComando(
                //    $"INSERT INTO Asitencia (nocontrol, fecha, asistencia) " +
                //    $"VALUES ('{nocontrol}', '{fecha}', {asistencia}) " +
                //    $"ON DUPLICATE KEY UPDATE asistencia = {asistencia}");


                valores.Add($"('{nocontrol}', '{fecha}', '{asistencia}')");
            }
            sb.Append(string.Join(", ", valores));
            sb.Append(" ON DUPLICATE KEY UPDATE asistencia = VALUES(asistencia)");

            datos.ejecutarComando(sb.ToString());


            MessageBox.Show("Asistencia guardada correctamente");
            CargarAlumnos();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.Columns["chkAsistencia"] != null)
            {
                dgvAlumnos.Columns.Remove("chkAsistencia");
            }
            CargarAlumnos();
        }
    }
}
