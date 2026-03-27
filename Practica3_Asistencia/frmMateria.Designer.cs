namespace Practica3_Asistencia
{
    partial class frmMateria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            tbBusqueda = new TextBox();
            label1 = new Label();
            msOpciones = new MenuStrip();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            asistenciaToolStripMenuItem1 = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            importarToolStripMenuItem = new ToolStripMenuItem();
            dgvAlumnos = new DataGridView();
            cmsHerramientas = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem2 = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            ofdExcel = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            msOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            cmsHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tbBusqueda);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(msOpciones);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAlumnos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 122;
            splitContainer1.TabIndex = 1;
            // 
            // tbBusqueda
            // 
            tbBusqueda.Location = new Point(191, 75);
            tbBusqueda.Name = "tbBusqueda";
            tbBusqueda.Size = new Size(372, 27);
            tbBusqueda.TabIndex = 2;
            tbBusqueda.TextChanged += tbBusqueda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 28);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Alumno";
            // 
            // msOpciones
            // 
            msOpciones.ImageScalingSize = new Size(20, 20);
            msOpciones.Items.AddRange(new ToolStripItem[] { modificarToolStripMenuItem1 });
            msOpciones.Location = new Point(0, 0);
            msOpciones.Name = "msOpciones";
            msOpciones.Size = new Size(800, 28);
            msOpciones.TabIndex = 1;
            msOpciones.Text = "menuStrip2";
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { asistenciaToolStripMenuItem1, agregarToolStripMenuItem, importarToolStripMenuItem });
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(81, 24);
            modificarToolStripMenuItem1.Text = "Alumnos";
            // 
            // asistenciaToolStripMenuItem1
            // 
            asistenciaToolStripMenuItem1.Name = "asistenciaToolStripMenuItem1";
            asistenciaToolStripMenuItem1.Size = new Size(158, 26);
            asistenciaToolStripMenuItem1.Text = "Asistencia";
            asistenciaToolStripMenuItem1.Click += asistenciaToolStripMenuItem1_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(158, 26);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // importarToolStripMenuItem
            // 
            importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            importarToolStripMenuItem.Size = new Size(158, 26);
            importarToolStripMenuItem.Text = "Importar";
            importarToolStripMenuItem.Click += importarToolStripMenuItem_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.ContextMenuStrip = cmsHerramientas;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(800, 324);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellClick += dgvAlumnos_CellClick;
            // 
            // cmsHerramientas
            // 
            cmsHerramientas.ImageScalingSize = new Size(20, 20);
            cmsHerramientas.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, modificarToolStripMenuItem2 });
            cmsHerramientas.Name = "cmsEliminar";
            cmsHerramientas.Size = new Size(211, 80);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(210, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem2
            // 
            modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            modificarToolStripMenuItem2.Size = new Size(210, 24);
            modificarToolStripMenuItem2.Text = "Modificar";
            modificarToolStripMenuItem2.Click += modificarToolStripMenuItem2_Click;
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(89, 24);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(87, 24);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // ofdExcel
            // 
            ofdExcel.FileName = "openFileDialog1";
            // 
            // frmMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            MainMenuStrip = msOpciones;
            Name = "frmMateria";
            Text = "Matemáticas";
            Load += frmMateria_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            msOpciones.ResumeLayout(false);
            msOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            cmsHerramientas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private TextBox tbBusqueda;
        private Label label1;
        private DataGridView dgvAlumnos;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private MenuStrip msOpciones;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private OpenFileDialog ofdExcel;
        private ToolStripMenuItem asistenciaToolStripMenuItem1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem importarToolStripMenuItem;
        private ContextMenuStrip cmsHerramientas;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem2;
    }
}
