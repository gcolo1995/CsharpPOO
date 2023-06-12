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
            this.listTipoAl = new System.Windows.Forms.ListBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxBECA = new System.Windows.Forms.GroupBox();
            this.lblCodigoBeca = new System.Windows.Forms.Label();
            this.lblFechaOtorgBeca = new System.Windows.Forms.Label();
            this.lblImporteBeca = new System.Windows.Forms.Label();
            this.txtCodigoBeca = new System.Windows.Forms.TextBox();
            this.dtpFechaOtorg = new System.Windows.Forms.DateTimePicker();
            this.numImporte = new System.Windows.Forms.NumericUpDown();
            this.btnModifBeca = new System.Windows.Forms.Button();
            this.btnBajaBeca = new System.Windows.Forms.Button();
            this.btnAltaBeca = new System.Windows.Forms.Button();
            this.btnAsignarBeca = new System.Windows.Forms.Button();
            this.btnQuitarBeca = new System.Windows.Forms.Button();
            this.btnSimularPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecasAlumno)).BeginInit();
            this.gbxAlumno.SuspendLayout();
            this.gboxBECA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(6, 27);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(269, 138);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // dgvBecas
            // 
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Location = new System.Drawing.Point(6, 27);
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
            this.btnAltaAlumno.Location = new System.Drawing.Point(24, 325);
            this.btnAltaAlumno.Name = "btnAltaAlumno";
            this.btnAltaAlumno.Size = new System.Drawing.Size(76, 23);
            this.btnAltaAlumno.TabIndex = 3;
            this.btnAltaAlumno.Text = "ALTA";
            this.btnAltaAlumno.UseVisualStyleBackColor = true;
            this.btnAltaAlumno.Click += new System.EventHandler(this.btnAltaAlumno_Click);
            // 
            // btnBajaAlumno
            // 
            this.btnBajaAlumno.Location = new System.Drawing.Point(106, 325);
            this.btnBajaAlumno.Name = "btnBajaAlumno";
            this.btnBajaAlumno.Size = new System.Drawing.Size(76, 23);
            this.btnBajaAlumno.TabIndex = 4;
            this.btnBajaAlumno.Text = "BAJA";
            this.btnBajaAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(188, 325);
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
            this.gbxAlumno.Controls.Add(this.dgvAlumnos);
            this.gbxAlumno.Controls.Add(this.txtApellido);
            this.gbxAlumno.Controls.Add(this.txtNombre);
            this.gbxAlumno.Controls.Add(this.lblTipo);
            this.gbxAlumno.Controls.Add(this.lblDni);
            this.gbxAlumno.Controls.Add(this.lblApellido);
            this.gbxAlumno.Controls.Add(this.lblNombre);
            this.gbxAlumno.Location = new System.Drawing.Point(12, 15);
            this.gbxAlumno.Name = "gbxAlumno";
            this.gbxAlumno.Size = new System.Drawing.Size(286, 394);
            this.gbxAlumno.TabIndex = 7;
            this.gbxAlumno.TabStop = false;
            this.gbxAlumno.Text = "ALUMNOS";
            // 
            // listTipoAl
            // 
            this.listTipoAl.FormattingEnabled = true;
            this.listTipoAl.Items.AddRange(new object[] {
            "Ingresante",
            "Grado",
            "Posgrado"});
            this.listTipoAl.Location = new System.Drawing.Point(105, 243);
            this.listTipoAl.Name = "listTipoAl";
            this.listTipoAl.Size = new System.Drawing.Size(158, 30);
            this.listTipoAl.TabIndex = 9;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(21, 286);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(51, 13);
            this.lblLegajo.TabIndex = 8;
            this.lblLegajo.Text = "LEGAJO:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(105, 279);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(158, 20);
            this.txtLegajo.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(105, 220);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(158, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(105, 197);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 174);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 251);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "TIPO:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 227);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 204);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 182);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(668, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // gboxBECA
            // 
            this.gboxBECA.Controls.Add(this.btnModifBeca);
            this.gboxBECA.Controls.Add(this.btnBajaBeca);
            this.gboxBECA.Controls.Add(this.btnAltaBeca);
            this.gboxBECA.Controls.Add(this.numImporte);
            this.gboxBECA.Controls.Add(this.dtpFechaOtorg);
            this.gboxBECA.Controls.Add(this.txtCodigoBeca);
            this.gboxBECA.Controls.Add(this.lblImporteBeca);
            this.gboxBECA.Controls.Add(this.dgvBecas);
            this.gboxBECA.Controls.Add(this.lblFechaOtorgBeca);
            this.gboxBECA.Controls.Add(this.lblCodigoBeca);
            this.gboxBECA.Location = new System.Drawing.Point(304, 15);
            this.gboxBECA.Name = "gboxBECA";
            this.gboxBECA.Size = new System.Drawing.Size(238, 329);
            this.gboxBECA.TabIndex = 9;
            this.gboxBECA.TabStop = false;
            this.gboxBECA.Text = "BECAS";
            // 
            // lblCodigoBeca
            // 
            this.lblCodigoBeca.AutoSize = true;
            this.lblCodigoBeca.Location = new System.Drawing.Point(20, 182);
            this.lblCodigoBeca.Name = "lblCodigoBeca";
            this.lblCodigoBeca.Size = new System.Drawing.Size(52, 13);
            this.lblCodigoBeca.TabIndex = 0;
            this.lblCodigoBeca.Text = "CODIGO:";
            // 
            // lblFechaOtorgBeca
            // 
            this.lblFechaOtorgBeca.AutoSize = true;
            this.lblFechaOtorgBeca.Location = new System.Drawing.Point(20, 211);
            this.lblFechaOtorgBeca.Name = "lblFechaOtorgBeca";
            this.lblFechaOtorgBeca.Size = new System.Drawing.Size(98, 26);
            this.lblFechaOtorgBeca.TabIndex = 1;
            this.lblFechaOtorgBeca.Text = "FECHA DE\r\nOTORGAMIENTO:";
            // 
            // lblImporteBeca
            // 
            this.lblImporteBeca.AutoSize = true;
            this.lblImporteBeca.Location = new System.Drawing.Point(20, 250);
            this.lblImporteBeca.Name = "lblImporteBeca";
            this.lblImporteBeca.Size = new System.Drawing.Size(59, 13);
            this.lblImporteBeca.TabIndex = 2;
            this.lblImporteBeca.Text = "IMPORTE:";
            // 
            // txtCodigoBeca
            // 
            this.txtCodigoBeca.Location = new System.Drawing.Point(93, 179);
            this.txtCodigoBeca.Name = "txtCodigoBeca";
            this.txtCodigoBeca.Size = new System.Drawing.Size(132, 20);
            this.txtCodigoBeca.TabIndex = 10;
            // 
            // dtpFechaOtorg
            // 
            this.dtpFechaOtorg.Location = new System.Drawing.Point(122, 211);
            this.dtpFechaOtorg.MaxDate = new System.DateTime(2023, 6, 12, 0, 0, 0, 0);
            this.dtpFechaOtorg.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaOtorg.Name = "dtpFechaOtorg";
            this.dtpFechaOtorg.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaOtorg.TabIndex = 11;
            this.dtpFechaOtorg.Value = new System.DateTime(2023, 6, 12, 0, 0, 0, 0);
            // 
            // numImporte
            // 
            this.numImporte.Location = new System.Drawing.Point(97, 248);
            this.numImporte.Name = "numImporte";
            this.numImporte.Size = new System.Drawing.Size(128, 20);
            this.numImporte.TabIndex = 12;
            // 
            // btnModifBeca
            // 
            this.btnModifBeca.Location = new System.Drawing.Point(153, 283);
            this.btnModifBeca.Name = "btnModifBeca";
            this.btnModifBeca.Size = new System.Drawing.Size(75, 23);
            this.btnModifBeca.TabIndex = 15;
            this.btnModifBeca.Text = "MODIFICAR";
            this.btnModifBeca.UseVisualStyleBackColor = true;
            // 
            // btnBajaBeca
            // 
            this.btnBajaBeca.Location = new System.Drawing.Point(85, 283);
            this.btnBajaBeca.Name = "btnBajaBeca";
            this.btnBajaBeca.Size = new System.Drawing.Size(53, 23);
            this.btnBajaBeca.TabIndex = 14;
            this.btnBajaBeca.Text = "BAJA";
            this.btnBajaBeca.UseVisualStyleBackColor = true;
            // 
            // btnAltaBeca
            // 
            this.btnAltaBeca.Location = new System.Drawing.Point(23, 283);
            this.btnAltaBeca.Name = "btnAltaBeca";
            this.btnAltaBeca.Size = new System.Drawing.Size(56, 23);
            this.btnAltaBeca.TabIndex = 13;
            this.btnAltaBeca.Text = "ALTA";
            this.btnAltaBeca.UseVisualStyleBackColor = true;
            // 
            // btnAsignarBeca
            // 
            this.btnAsignarBeca.Location = new System.Drawing.Point(570, 200);
            this.btnAsignarBeca.Name = "btnAsignarBeca";
            this.btnAsignarBeca.Size = new System.Drawing.Size(95, 40);
            this.btnAsignarBeca.TabIndex = 10;
            this.btnAsignarBeca.Text = "ASIGNAR\r\nBECA";
            this.btnAsignarBeca.UseVisualStyleBackColor = true;
            // 
            // btnQuitarBeca
            // 
            this.btnQuitarBeca.Location = new System.Drawing.Point(671, 200);
            this.btnQuitarBeca.Name = "btnQuitarBeca";
            this.btnQuitarBeca.Size = new System.Drawing.Size(90, 40);
            this.btnQuitarBeca.TabIndex = 11;
            this.btnQuitarBeca.Text = "QUITAR \r\nBECA";
            this.btnQuitarBeca.UseVisualStyleBackColor = true;
            // 
            // btnSimularPago
            // 
            this.btnSimularPago.Location = new System.Drawing.Point(570, 272);
            this.btnSimularPago.Name = "btnSimularPago";
            this.btnSimularPago.Size = new System.Drawing.Size(103, 47);
            this.btnSimularPago.TabIndex = 12;
            this.btnSimularPago.Text = "SIMULAR\r\nPAGO";
            this.btnSimularPago.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 418);
            this.Controls.Add(this.btnSimularPago);
            this.Controls.Add(this.btnQuitarBeca);
            this.Controls.Add(this.gboxBECA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignarBeca);
            this.Controls.Add(this.gbxAlumno);
            this.Controls.Add(this.dgvBecasAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecasAlumno)).EndInit();
            this.gbxAlumno.ResumeLayout(false);
            this.gbxAlumno.PerformLayout();
            this.gboxBECA.ResumeLayout(false);
            this.gboxBECA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImporte)).EndInit();
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
        private System.Windows.Forms.Button btnModifBeca;
        private System.Windows.Forms.Button btnBajaBeca;
        private System.Windows.Forms.Button btnAltaBeca;
        private System.Windows.Forms.NumericUpDown numImporte;
        private System.Windows.Forms.DateTimePicker dtpFechaOtorg;
        private System.Windows.Forms.TextBox txtCodigoBeca;
        private System.Windows.Forms.Label lblImporteBeca;
        private System.Windows.Forms.Label lblFechaOtorgBeca;
        private System.Windows.Forms.Label lblCodigoBeca;
        private System.Windows.Forms.Button btnAsignarBeca;
        private System.Windows.Forms.Button btnQuitarBeca;
        private System.Windows.Forms.Button btnSimularPago;
    }
}

