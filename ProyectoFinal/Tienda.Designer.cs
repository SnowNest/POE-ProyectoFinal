namespace ProyectoFinal
{
    partial class Tienda
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
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbprecios = new System.Windows.Forms.ListBox();
            this.lbCarrito = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbCategorias
            // 
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Items.AddRange(new object[] {
            "Pintura",
            "Plomeria",
            "Electrico",
            "Herramientas"});
            this.cbCategorias.Location = new System.Drawing.Point(12, 25);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbCategorias.TabIndex = 0;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una categoria:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(12, 65);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 21);
            this.cbProducto.TabIndex = 2;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elija producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elija cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 105);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(118, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(15, 131);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarCarrito.TabIndex = 6;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(15, 160);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(118, 23);
            this.btnCompra.TabIndex = 7;
            this.btnCompra.Text = "Terminar compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbprecios
            // 
            this.lbprecios.Enabled = false;
            this.lbprecios.FormattingEnabled = true;
            this.lbprecios.Location = new System.Drawing.Point(146, 12);
            this.lbprecios.Name = "lbprecios";
            this.lbprecios.Size = new System.Drawing.Size(120, 199);
            this.lbprecios.TabIndex = 9;
            // 
            // lbCarrito
            // 
            this.lbCarrito.FormattingEnabled = true;
            this.lbCarrito.Location = new System.Drawing.Point(272, 12);
            this.lbCarrito.Name = "lbCarrito";
            this.lbCarrito.Size = new System.Drawing.Size(120, 199);
            this.lbCarrito.TabIndex = 10;
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 228);
            this.Controls.Add(this.lbCarrito);
            this.Controls.Add(this.lbprecios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategorias);
            this.Name = "Tienda";
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.Tienda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lbprecios;
        private System.Windows.Forms.ListBox lbCarrito;
    }
}