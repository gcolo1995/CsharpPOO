namespace Clase8
{
    partial class Form1
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
            grpboxArticulos = new GroupBox();
            btnAgregarArt = new Button();
            btnModificarArt = new Button();
            btnEliminarArt = new Button();
            grpboxCategorias = new GroupBox();
            btnEliminarCat = new Button();
            btnModificarCat = new Button();
            btnAgregarCat = new Button();
            lblNombreArt = new Label();
            lblCategoriaArt = new Label();
            lblPrecioCompraArt = new Label();
            lblPrecioVentaArt = new Label();
            lblCantidadArt = new Label();
            lblCodigoArt = new Label();
            txtCodigoArt = new TextBox();
            txtNombreArt = new TextBox();
            txtCategoriaArt = new TextBox();
            txtPrecioCompraArt = new TextBox();
            txtPrecioVentaArt = new TextBox();
            txtCantidadArt = new TextBox();
            grpboxArticulos.SuspendLayout();
            grpboxCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxArticulos
            // 
            grpboxArticulos.Controls.Add(txtCantidadArt);
            grpboxArticulos.Controls.Add(txtPrecioVentaArt);
            grpboxArticulos.Controls.Add(txtPrecioCompraArt);
            grpboxArticulos.Controls.Add(txtCategoriaArt);
            grpboxArticulos.Controls.Add(txtNombreArt);
            grpboxArticulos.Controls.Add(txtCodigoArt);
            grpboxArticulos.Controls.Add(lblCodigoArt);
            grpboxArticulos.Controls.Add(lblCantidadArt);
            grpboxArticulos.Controls.Add(lblPrecioVentaArt);
            grpboxArticulos.Controls.Add(lblPrecioCompraArt);
            grpboxArticulos.Controls.Add(lblCategoriaArt);
            grpboxArticulos.Controls.Add(lblNombreArt);
            grpboxArticulos.Controls.Add(btnEliminarArt);
            grpboxArticulos.Controls.Add(btnModificarArt);
            grpboxArticulos.Controls.Add(btnAgregarArt);
            grpboxArticulos.Location = new Point(10, 111);
            grpboxArticulos.Name = "grpboxArticulos";
            grpboxArticulos.Size = new Size(323, 204);
            grpboxArticulos.TabIndex = 0;
            grpboxArticulos.TabStop = false;
            grpboxArticulos.Text = "ARTICULOS";
            // 
            // btnAgregarArt
            // 
            btnAgregarArt.Location = new Point(5, 168);
            btnAgregarArt.Name = "btnAgregarArt";
            btnAgregarArt.Size = new Size(83, 31);
            btnAgregarArt.TabIndex = 0;
            btnAgregarArt.Text = "AGREGAR";
            btnAgregarArt.UseVisualStyleBackColor = true;
            // 
            // btnModificarArt
            // 
            btnModificarArt.Location = new Point(115, 168);
            btnModificarArt.Name = "btnModificarArt";
            btnModificarArt.Size = new Size(88, 31);
            btnModificarArt.TabIndex = 1;
            btnModificarArt.Text = "MODIFICAR";
            btnModificarArt.UseVisualStyleBackColor = true;
            btnModificarArt.Click += btnModificarArt_Click;
            // 
            // btnEliminarArt
            // 
            btnEliminarArt.Location = new Point(224, 168);
            btnEliminarArt.Name = "btnEliminarArt";
            btnEliminarArt.Size = new Size(88, 31);
            btnEliminarArt.TabIndex = 2;
            btnEliminarArt.Text = "ELIMINAR";
            btnEliminarArt.UseVisualStyleBackColor = true;
            // 
            // grpboxCategorias
            // 
            grpboxCategorias.Controls.Add(btnEliminarCat);
            grpboxCategorias.Controls.Add(btnModificarCat);
            grpboxCategorias.Controls.Add(btnAgregarCat);
            grpboxCategorias.Location = new Point(353, 111);
            grpboxCategorias.Name = "grpboxCategorias";
            grpboxCategorias.Size = new Size(323, 204);
            grpboxCategorias.TabIndex = 3;
            grpboxCategorias.TabStop = false;
            grpboxCategorias.Text = "CATEGORIAS";
            // 
            // btnEliminarCat
            // 
            btnEliminarCat.Location = new Point(229, 167);
            btnEliminarCat.Name = "btnEliminarCat";
            btnEliminarCat.Size = new Size(88, 31);
            btnEliminarCat.TabIndex = 2;
            btnEliminarCat.Text = "ELIMINAR";
            btnEliminarCat.UseVisualStyleBackColor = true;
            // 
            // btnModificarCat
            // 
            btnModificarCat.Location = new Point(120, 167);
            btnModificarCat.Name = "btnModificarCat";
            btnModificarCat.Size = new Size(88, 31);
            btnModificarCat.TabIndex = 1;
            btnModificarCat.Text = "MODIFICAR";
            btnModificarCat.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.Location = new Point(10, 167);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(83, 31);
            btnAgregarCat.TabIndex = 0;
            btnAgregarCat.Text = "AGREGAR";
            btnAgregarCat.UseVisualStyleBackColor = true;
            // 
            // lblNombreArt
            // 
            lblNombreArt.AutoSize = true;
            lblNombreArt.Location = new Point(6, 46);
            lblNombreArt.Name = "lblNombreArt";
            lblNombreArt.Size = new Size(59, 15);
            lblNombreArt.TabIndex = 3;
            lblNombreArt.Text = "NOMBRE:";
            // 
            // lblCategoriaArt
            // 
            lblCategoriaArt.AutoSize = true;
            lblCategoriaArt.Location = new Point(5, 71);
            lblCategoriaArt.Name = "lblCategoriaArt";
            lblCategoriaArt.Size = new Size(72, 15);
            lblCategoriaArt.TabIndex = 4;
            lblCategoriaArt.Text = "CATEGORIA:";
            // 
            // lblPrecioCompraArt
            // 
            lblPrecioCompraArt.AutoSize = true;
            lblPrecioCompraArt.Location = new Point(6, 95);
            lblPrecioCompraArt.Name = "lblPrecioCompraArt";
            lblPrecioCompraArt.Size = new Size(103, 15);
            lblPrecioCompraArt.TabIndex = 5;
            lblPrecioCompraArt.Text = "PRECIO COMPRA:";
            // 
            // lblPrecioVentaArt
            // 
            lblPrecioVentaArt.AutoSize = true;
            lblPrecioVentaArt.Location = new Point(6, 120);
            lblPrecioVentaArt.Name = "lblPrecioVentaArt";
            lblPrecioVentaArt.Size = new Size(88, 15);
            lblPrecioVentaArt.TabIndex = 6;
            lblPrecioVentaArt.Text = "PRECIO VENTA:";
            // 
            // lblCantidadArt
            // 
            lblCantidadArt.AutoSize = true;
            lblCantidadArt.Location = new Point(6, 145);
            lblCantidadArt.Name = "lblCantidadArt";
            lblCantidadArt.Size = new Size(68, 15);
            lblCantidadArt.TabIndex = 7;
            lblCantidadArt.Text = "CANTIDAD:";
            // 
            // lblCodigoArt
            // 
            lblCodigoArt.AutoSize = true;
            lblCodigoArt.Location = new Point(6, 19);
            lblCodigoArt.Name = "lblCodigoArt";
            lblCodigoArt.Size = new Size(55, 15);
            lblCodigoArt.TabIndex = 8;
            lblCodigoArt.Text = "CODIGO:";
            // 
            // txtCodigoArt
            // 
            txtCodigoArt.Location = new Point(115, 13);
            txtCodigoArt.Name = "txtCodigoArt";
            txtCodigoArt.Size = new Size(165, 23);
            txtCodigoArt.TabIndex = 9;
            // 
            // txtNombreArt
            // 
            txtNombreArt.Location = new Point(115, 39);
            txtNombreArt.Name = "txtNombreArt";
            txtNombreArt.Size = new Size(165, 23);
            txtNombreArt.TabIndex = 10;
            // 
            // txtCategoriaArt
            // 
            txtCategoriaArt.Location = new Point(115, 65);
            txtCategoriaArt.Name = "txtCategoriaArt";
            txtCategoriaArt.Size = new Size(165, 23);
            txtCategoriaArt.TabIndex = 11;
            // 
            // txtPrecioCompraArt
            // 
            txtPrecioCompraArt.Location = new Point(115, 91);
            txtPrecioCompraArt.Name = "txtPrecioCompraArt";
            txtPrecioCompraArt.Size = new Size(165, 23);
            txtPrecioCompraArt.TabIndex = 12;
            // 
            // txtPrecioVentaArt
            // 
            txtPrecioVentaArt.Location = new Point(115, 116);
            txtPrecioVentaArt.Name = "txtPrecioVentaArt";
            txtPrecioVentaArt.Size = new Size(165, 23);
            txtPrecioVentaArt.TabIndex = 13;
            // 
            // txtCantidadArt
            // 
            txtCantidadArt.Location = new Point(115, 141);
            txtCantidadArt.Name = "txtCantidadArt";
            txtCantidadArt.Size = new Size(165, 23);
            txtCantidadArt.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 342);
            Controls.Add(grpboxCategorias);
            Controls.Add(grpboxArticulos);
            Name = "Form1";
            Text = "Form1";
            grpboxArticulos.ResumeLayout(false);
            grpboxArticulos.PerformLayout();
            grpboxCategorias.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxArticulos;
        private Button btnModificarArt;
        private Button btnAgregarArt;
        private Button btnEliminarArt;
        private TextBox txtCantidadArt;
        private TextBox txtPrecioVentaArt;
        private TextBox txtPrecioCompraArt;
        private TextBox txtCategoriaArt;
        private TextBox txtNombreArt;
        private TextBox txtCodigoArt;
        private Label lblCodigoArt;
        private Label lblCantidadArt;
        private Label lblPrecioVentaArt;
        private Label lblPrecioCompraArt;
        private Label lblCategoriaArt;
        private Label lblNombreArt;
        private GroupBox grpboxCategorias;
        private Button btnEliminarCat;
        private Button btnModificarCat;
        private Button btnAgregarCat;
    }
}