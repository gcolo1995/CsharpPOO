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
            this.lblAlumnos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecasAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(18, 40);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(261, 138);
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
            this.btnAltaAlumno.Location = new System.Drawing.Point(18, 201);
            this.btnAltaAlumno.Name = "btnAltaAlumno";
            this.btnAltaAlumno.Size = new System.Drawing.Size(76, 23);
            this.btnAltaAlumno.TabIndex = 3;
            this.btnAltaAlumno.Text = "ALTA";
            this.btnAltaAlumno.UseVisualStyleBackColor = true;
            // 
            // btnBajaAlumno
            // 
            this.btnBajaAlumno.Location = new System.Drawing.Point(111, 201);
            this.btnBajaAlumno.Name = "btnBajaAlumno";
            this.btnBajaAlumno.Size = new System.Drawing.Size(76, 23);
            this.btnBajaAlumno.TabIndex = 4;
            this.btnBajaAlumno.Text = "BAJA";
            this.btnBajaAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(204, 201);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAlumno.TabIndex = 5;
            this.btnModificarAlumno.Text = "MODIFICAR";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(118, 181);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(60, 13);
            this.lblAlumnos.TabIndex = 6;
            this.lblAlumnos.Text = "ALUMNOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.btnModificarAlumno);
            this.Controls.Add(this.btnBajaAlumno);
            this.Controls.Add(this.btnAltaAlumno);
            this.Controls.Add(this.dgvBecasAlumno);
            this.Controls.Add(this.dgvBecas);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecasAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.DataGridView dgvBecasAlumno;
        private System.Windows.Forms.Button btnAltaAlumno;
        private System.Windows.Forms.Button btnBajaAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Label lblAlumnos;
    }
}

