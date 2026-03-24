using OfficeOpenXml;
using Practica3_Asistencia.Forms;
using System.Data;
using winMySQL.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica3_Asistencia
{
    public partial class frmMateria : Form
    {
        Datos datos = new Datos();
        DataSet ds;

        public frmMateria()
        {
            InitializeComponent();
        }

        private void frmMateria_Load(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void Busqueda()
        {
            DataSet ds = datos.ejecutar("select *  from Alumnos " +
                $"WHERE nombre like '{tbBusqueda.Text}%'");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            string texto = tbBusqueda.Text.Trim();

            // Si el campo está vacío
            if (string.IsNullOrEmpty(texto))
            {
                DataSet dsTodos = datos.ejecutar("SELECT nocontrol, nombre, paterno, materno FROM Alumnos");
                dgvAlumnos.DataSource = dsTodos.Tables[0];
                return;
            }

            string consulta = "";

            // Detecta automáticamente si es número o texto
            if (long.TryParse(texto, out _))
            {
                // Es número = buscar por No. Control
                consulta = $"SELECT nocontrol, nombre, paterno, materno FROM Alumnos " +
                           $"WHERE nocontrol LIKE '{texto}%'";
            }
            else
            {
                // Es texto = buscar por nombre O apellido paterno O apellido materno
                consulta = $"SELECT nocontrol, nombre, paterno, materno FROM Alumnos " +
                           $"WHERE nombre LIKE '{texto}%' " +
                           $"OR paterno LIKE '{texto}%' " +
                           $"OR materno LIKE '{texto}%'";
            }

            DataSet ds = datos.ejecutar(consulta);

            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            String path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Luis Mota");
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;
                    DataTable dt = new DataTable();
                    for (int col = 1; col <= columnCount; col++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow drNew = dt.NewRow();
                        for (int col = 1; col <= columnCount; col++)
                        {
                            drNew[col - 1] = worksheet.Cells[row, col].Value.ToString();
                        }
                        dt.Rows.Add(drNew);
                        try
                        {
                            String comando = $"Insert Into Alumnos (nocontrol,nombre,paterno,materno) VALUES('{drNew.ItemArray[0]}','{drNew.ItemArray[1]}','{drNew.ItemArray[2]}','{drNew.ItemArray[3]}')";
                            datos.ejecutarComando(comando);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error en la fila {row} : {ex.Message}");
                        }
                    }
                }

            }
        }

        private void asistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAsistencia asistencia = new frmAsistencia();
            asistencia.Show();
        }

        private void dtpHoy_ValueChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar que truene si hacen clic en el encabezado
            if (e.RowIndex < 0) return;

            string nocontrol = dgvAlumnos.Rows[e.RowIndex].Cells["nocontrol"].Value.ToString();

            // Abrir form de historial pasando el nocontrol
            frmHistorial historial = new frmHistorial(nocontrol);
            historial.Show();
        }
    }
}
