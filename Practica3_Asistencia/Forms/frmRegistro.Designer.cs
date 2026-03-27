namespace Practica3_Asistencia.Forms
{
    partial class frmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNoControl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbPaterno = new TextBox();
            label4 = new Label();
            tbMaterno = new TextBox();
            btnRegistro = new Button();
            tbNombre = new TextBox();
            btnRegresar = new Button();
            statusStrip1 = new StatusStrip();
            tsslMensaje = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNoControl
            // 
            tbNoControl.Location = new Point(179, 22);
            tbNoControl.Name = "tbNoControl";
            tbNoControl.Size = new Size(265, 27);
            tbNoControl.TabIndex = 2;
            tbNoControl.TextChanged += tbNoControl_TextChanged;
            tbNoControl.KeyPress += tbNoControl_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "No. Control";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 76);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido Paterno";
            // 
            // tbPaterno
            // 
            tbPaterno.Location = new Point(179, 125);
            tbPaterno.Name = "tbPaterno";
            tbPaterno.Size = new Size(265, 27);
            tbPaterno.TabIndex = 5;
            tbPaterno.TextChanged += tbPaterno_TextChanged;
            tbPaterno.KeyPress += tbPaterno_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 184);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 6;
            label4.Text = "Apellido Materno";
            // 
            // tbMaterno
            // 
            tbMaterno.Location = new Point(179, 177);
            tbMaterno.Name = "tbMaterno";
            tbMaterno.Size = new Size(265, 27);
            tbMaterno.TabIndex = 7;
            tbMaterno.TextChanged += tbMaterno_TextChanged;
            tbMaterno.KeyPress += tbMaterno_KeyPress;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(78, 236);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(94, 29);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "REGISTRAR";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(179, 76);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(265, 27);
            tbNombre.TabIndex = 9;
            tbNombre.TextChanged += tbNombre_TextChanged;
            tbNombre.KeyPress += tbNombre_KeyPress;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(251, 236);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslMensaje });
            statusStrip1.Location = new Point(0, 273);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(453, 26);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslMensaje
            // 
            tsslMensaje.Name = "tsslMensaje";
            tsslMensaje.Size = new Size(13, 20);
            tsslMensaje.Text = " ";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 299);
            Controls.Add(statusStrip1);
            Controls.Add(btnRegresar);
            Controls.Add(tbNombre);
            Controls.Add(btnRegistro);
            Controls.Add(tbMaterno);
            Controls.Add(label4);
            Controls.Add(tbPaterno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNoControl);
            Name = "frmRegistro";
            Text = "Registrar";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNoControl;
        private Label label1;
        private TextBox tbNombre;
        private Label label2;
        private Label label3;
        private TextBox tbPaterno;
        private Label label4;
        private TextBox tbMaterno;
        private Button btnRegistro;
        private Button btnRegresar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslMensaje;
    }
}