namespace Factura
{
    partial class FormFactura
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
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.cbxRazonSocial = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroFact = new System.Windows.Forms.Label();
            this.txtNroFact = new System.Windows.Forms.TextBox();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvDetalleFact = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFact)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(16, 15);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(86, 13);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "RAZON SOCIAL";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(16, 37);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT";
            // 
            // cbxRazonSocial
            // 
            this.cbxRazonSocial.FormattingEnabled = true;
            this.cbxRazonSocial.Location = new System.Drawing.Point(117, 7);
            this.cbxRazonSocial.Name = "cbxRazonSocial";
            this.cbxRazonSocial.Size = new System.Drawing.Size(221, 21);
            this.cbxRazonSocial.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(308, 414);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(117, 33);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(150, 20);
            this.txtCuit.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 90);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "FECHA";
            // 
            // lblNroFact
            // 
            this.lblNroFact.AutoSize = true;
            this.lblNroFact.Location = new System.Drawing.Point(16, 65);
            this.lblNroFact.Name = "lblNroFact";
            this.lblNroFact.Size = new System.Drawing.Size(72, 13);
            this.lblNroFact.TabIndex = 6;
            this.lblNroFact.Text = "Nº FACTURA";
            // 
            // txtNroFact
            // 
            this.txtNroFact.Location = new System.Drawing.Point(117, 59);
            this.txtNroFact.Name = "txtNroFact";
            this.txtNroFact.Size = new System.Drawing.Size(150, 20);
            this.txtNroFact.TabIndex = 7;
            // 
            // dtmFecha
            // 
            this.dtmFecha.Location = new System.Drawing.Point(117, 87);
            this.dtmFecha.MaxDate = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            this.dtmFecha.MinDate = new System.DateTime(2023, 6, 26, 0, 0, 0, 0);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(149, 20);
            this.dtmFecha.TabIndex = 8;
            this.dtmFecha.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(19, 119);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(467, 70);
            this.dgvProductos.TabIndex = 9;
            this.dgvProductos.TabStop = false;
            // 
            // dgvDetalleFact
            // 
            this.dgvDetalleFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFact.Location = new System.Drawing.Point(19, 236);
            this.dgvDetalleFact.Name = "dgvDetalleFact";
            this.dgvDetalleFact.Size = new System.Drawing.Size(467, 156);
            this.dgvDetalleFact.TabIndex = 10;
            this.dgvDetalleFact.TabStop = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(51, 195);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(113, 35);
            this.btnAgregarProducto.TabIndex = 11;
            this.btnAgregarProducto.Text = "AGREGAR\r\nPRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(192, 195);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(113, 35);
            this.btnModificarProducto.TabIndex = 12;
            this.btnModificarProducto.Text = "MODIFICAR\r\nPRODUCTO";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(343, 195);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(113, 35);
            this.btnEliminarProducto.TabIndex = 13;
            this.btnEliminarProducto.Text = "ELIMINAR\r\nPRODUCTO";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(403, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 43);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(343, 65);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 24);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(423, 65);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 24);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(373, 411);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(113, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvDetalleFact);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.dtmFecha);
            this.Controls.Add(this.txtNroFact);
            this.Controls.Add(this.lblNroFact);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbxRazonSocial);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblRazonSocial);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.ComboBox cbxRazonSocial;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroFact;
        private System.Windows.Forms.TextBox txtNroFact;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvDetalleFact;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTotal;
    }
}