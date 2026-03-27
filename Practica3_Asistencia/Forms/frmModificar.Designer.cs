namespace Practica3_Asistencia.Forms
{
    partial class frmModificar
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
            label1 = new Label();
            tbNombre = new TextBox();
            tbPaterno = new TextBox();
            label2 = new Label();
            tbMaterno = new TextBox();
            label3 = new Label();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(181, 20);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(198, 27);
            tbNombre.TabIndex = 1;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // tbPaterno
            // 
            tbPaterno.Location = new Point(181, 74);
            tbPaterno.Name = "tbPaterno";
            tbPaterno.Size = new Size(198, 27);
            tbPaterno.TabIndex = 3;
            tbPaterno.TextChanged += tbPaterno_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 81);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido Paterno";
            // 
            // tbMaterno
            // 
            tbMaterno.Location = new Point(181, 133);
            tbMaterno.Name = "tbMaterno";
            tbMaterno.Size = new Size(198, 27);
            tbMaterno.TabIndex = 5;
            tbMaterno.TextChanged += tbMaterno_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 140);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido Materno";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(128, 189);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(113, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 248);
            Controls.Add(btnActualizar);
            Controls.Add(tbMaterno);
            Controls.Add(label3);
            Controls.Add(tbPaterno);
            Controls.Add(label2);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Name = "frmModificar";
            Text = "frmModificar";
            Load += frmModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private TextBox tbPaterno;
        private Label label2;
        private TextBox tbMaterno;
        private Label label3;
        private Button btnActualizar;
    }
}