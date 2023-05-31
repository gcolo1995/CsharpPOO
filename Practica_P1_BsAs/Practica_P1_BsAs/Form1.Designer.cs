namespace Practica_P1_BsAs
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.dgvBecasAlumno = new System.Windows.Forms.DataGridView();
            this.btnAltaAlumno = new System.Windows.Forms.Button();
            this.btnBajaAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.gbxAlumno = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.listTipoAl = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxBECA = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecasAlumno)).BeginInit();
            this.gbxAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(18, 40);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(269, 138);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // dgvBecas
            // 
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Location = new System.Drawing.Point(305, 41);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.Size = new System.Drawing.Size(227, 136);
            this.dgvBecas.TabIndex = 1;
            // 
            // dgvBecasAlumno
            // 
            this.dgvBecasAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecasAlumno.Location = new System.Drawing.Point(548, 42);
            this.dgvBecasAlumno.Name = "dgvBecasAlumno";
            this.dgvBecasAlumno.Size = new System.Drawing.Size(227, 135);
            this.dgvBecasAlumno.TabIndex = 2;
            // 
            // btnAltaAlumno
            // 
            this.btnAltaAlumno.Location = new System.Drawing.Point(15, 170);
            this.btnAltaAlumno.Name = "btnAltaAlumno";
            this.btnAltaAlumno.Size = new System.Drawing.Size(76, 23);
            this.btnAltaAlumno.TabIndex = 3;
            this.btnAltaAlumno.Text = "ALTA";
            this.btnAltaAlumno.UseVisualStyleBackColor = true;
            this.btnAltaAlumno.Click += new System.EventHandler(this.btnAltaAlumno_Click);
            // 
            // btnBajaAlumno
            // 
            this.btnBajaAlumno.Location = new System.Drawing.Point(97, 170);
            this.btnBajaAlumno.Name = "btnBajaAlumno";
            this.btnBajaAlumno.Size = new System.Drawing.Size(76, 23);
            this.btnBajaAlumno.TabIndex = 4;
            this.btnBajaAlumno.Text = "BAJA";
            this.btnBajaAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(179, 170);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAlumno.TabIndex = 5;
            this.btnModificarAlumno.Text = "MODIFICAR";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // gbxAlumno
            // 
            this.gbxAlumno.Controls.Add(this.listTipoAl);
            this.gbxAlumno.Controls.Add(this.btnModificarAlumno);
            this.gbxAlumno.Controls.Add(this.lblLegajo);
            this.gbxAlumno.Controls.Add(this.btnBajaAlumno);
            this.gbxAlumno.Controls.Add(this.txtLegajo);
            this.gbxAlumno.Controls.Add(this.btnAltaAlumno);
            this.gbxAlumno.Controls.Add(this.txtDni);
            this.gbxAlumno.Controls.Add(this.txtApellido);
            this.gbxAlumno.Controls.Add(this.txtNombre);
            this.gbxAlumno.Controls.Add(this.lblTipo);
            this.gbxAlumno.Controls.Add(this.lblDni);
            this.gbxAlumno.Controls.Add(this.lblApellido);
            this.gbxAlumno.Controls.Add(this.lblNombre);
            this.gbxAlumno.Location = new System.Drawing.Point(18, 200);
            this.gbxAlumno.Name = "gbxAlumno";
            this.gbxAlumno.Size = new System.Drawing.Size(269, 209);
            this.gbxAlumno.TabIndex = 7;
            this.gbxAlumno.TabStop = false;
            this.gbxAlumno.Text = "ALUMNOS";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 49);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 72);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 96);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "TIPO:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(96, 42);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(96, 65);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(158, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(96, 124);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(158, 20);
            this.txtLegajo.TabIndex = 7;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(12, 131);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(51, 13);
            this.lblLegajo.TabIndex = 8;
            this.lblLegajo.Text = "LEGAJO:";
            // 
            // listTipoAl
            // 
            this.listTipoAl.FormattingEnabled = true;
            this.listTipoAl.Items.AddRange(new object[] {
            "Ingresante",
            "Grado",
            "Posgrado"});
            this.listTipoAl.Location = new System.Drawing.Point(96, 88);
            this.listTipoAl.Name = "listTipoAl";
            this.listTipoAl.Size = new System.Drawing.Size(158, 30);
            this.listTipoAl.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(660, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // gboxBECA
            // 
            this.gboxBECA.Location = new System.Drawing.Point(308, 200);
            this.gboxBECA.Name = "gboxBECA";
            this.gboxBECA.Size = new System.Drawing.Size(223, 209);
            this.gboxBECA.TabIndex = 9;
            this.gboxBECA.TabStop = false;
            this.gboxBECA.Text = "BECAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboxBECA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxAlumno);
            this.Controls.Add(this.dgvBecasAlumno);
            this.Controls.Add(this.dgvBecas);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecasAlumno)).EndInit();
            this.gbxAlumno.ResumeLayout(false);
            this.gbxAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.DataGridView dgvBecasAlumno;
        private System.Windows.Forms.Button btnAltaAlumno;
        private System.Windows.Forms.Button btnBajaAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.GroupBox gbxAlumno;
        private System.Windows.Forms.ListBox listTipoAl;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gboxBECA;
    }
}

