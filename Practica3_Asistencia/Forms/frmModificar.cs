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
    public partial class frmModificar : Form
    {
        DataSet ds = new DataSet();
        Datos datos = new Datos();
        string nocontrol;
        public frmModificar(string nocontrol)
        {
            InitializeComponent();
            this.nocontrol = nocontrol;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            datos.ejecutarComando($"UPDATE Alumnos SET nombre ='{tbNombre.Text}', paterno ='{tbPaterno.Text}', materno ='{tbMaterno.Text}'" +
                $"WHERE nocontrol ='{nocontrol}'");
            this.Close();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.ejecutar(
        $"SELECT nombre, paterno, materno FROM Alumnos WHERE nocontrol = '{nocontrol}'");

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No se encontró", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow fila = ds.Tables[0].Rows[0];

            tbNombre.Text = fila["nombre"].ToString();
            tbPaterno.Text = fila["paterno"].ToString();
            tbMaterno.Text = fila["materno"].ToString();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            int cantidad = tbNombre.Text.Length;
            char[] texto = new char[cantidad];
            texto = tbNombre.Text.ToCharArray();
            for (int i = 0; i < texto.Length; i++)
            {
                if (!((texto[i] >= 65 && texto[i] <= 90) || texto[i] == 32 || (texto[i] >= 97 && texto[i] <= 122)))
                {
                    texto[i] = ' ';
                    MessageBox.Show("No es una letra");

                }
            }
            tbNombre.Text = string.Join("", texto);
        }

        private void tbPaterno_TextChanged(object sender, EventArgs e)
        {
            int cantidad = tbPaterno.Text.Length;
            char[] texto = new char[cantidad];
            texto = tbPaterno.Text.ToCharArray();
            for (int i = 0; i < texto.Length; i++)
            {
                if (!((texto[i] >= 65 && texto[i] <= 90) || texto[i] == 32 || (texto[i] >= 97 && texto[i] <= 122)))
                {
                    texto[i] = ' ';
                    MessageBox.Show("No es una letra");

                }
            }
            tbPaterno.Text = string.Join("", texto);
        }

        private void tbMaterno_TextChanged(object sender, EventArgs e)
        {
            int cantidad = tbMaterno.Text.Length;
            char[] texto = new char[cantidad];
            texto = tbMaterno.Text.ToCharArray();
            for (int i = 0; i < texto.Length; i++)
            {
                if (!((texto[i] >= 65 && texto[i] <= 90) || texto[i] == 32 || (texto[i] >= 97 && texto[i] <= 122)))
                {
                    texto[i] = ' ';
                    MessageBox.Show("No es una letra");

                }
            }
            tbMaterno.Text = string.Join("", texto);
        }
    }
}
