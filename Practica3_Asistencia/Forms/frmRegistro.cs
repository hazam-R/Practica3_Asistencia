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

    public partial class frmRegistro : Form
    {
        Datos datos = new Datos();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private  void btnRegistro_Click(object sender, EventArgs e)
        {
            if(tbNoControl.Text == "" || tbNombre.Text == "" || tbPaterno.Text =="" || tbMaterno.Text == "")
            {
                MessageBox.Show("Campos Vacios");
                return;
            }
            try
            {
                datos.ejecutar($"INSERT INTO Alumnos VALUES ({tbNoControl.Text.Trim()},'{tbNombre.Text}','{tbPaterno.Text.Trim()}','{tbMaterno.Text.Trim()}')");
                tsslMensaje.Text = "Registro exitoso";
                tsslMensaje.ForeColor = Color.Green;
                Task.Delay(1000);
                tbNoControl.Text = "";
                tbNombre.Text = "";
                tbPaterno.Text = "";
                tbMaterno.Text = "";
            }
            catch (Exception ex) {
                tsslMensaje.Text = "Registro fallido " + ex.Message;
                tsslMensaje.ForeColor = Color.Red;
            }

            Task.Delay(3000);
            tsslMensaje.Text = "";

        }

        private void tbNoControl_TextChanged(object sender, EventArgs e)
        {
            int cantidad = tbNoControl.Text.Length;
            char[] texto = new char[cantidad];
            texto = tbNoControl.Text.ToCharArray();
            for (int i = 0; i < texto.Length; i++)
            {
                if (!(texto[i] >= 48 && texto[i] <= 57 || texto[i] == 32))
                {
                    texto[i] = ' ';
                    MessageBox.Show("No es un numero");

                }
            }
            tbNoControl.Text = string.Join("", texto);

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

        private void tbNoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbNombre.Focus();
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbPaterno.Focus();
            }
        }

        private void tbPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbMaterno.Focus();
            }
        }

        private void tbMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnRegistro.Focus();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
