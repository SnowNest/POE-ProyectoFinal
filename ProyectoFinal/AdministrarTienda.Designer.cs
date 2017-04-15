namespace ProyectoFinal
{
    partial class AdministrarTienda
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
            this.btnModificarStock = new System.Windows.Forms.Button();
            this.btnOpcionAgregarProducto = new System.Windows.Forms.Button();
            this.btnOpcionEliminar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarStock
            // 
            this.btnModificarStock.Location = new System.Drawing.Point(12, 12);
            this.btnModificarStock.Name = "btnModificarStock";
            this.btnModificarStock.Size = new System.Drawing.Size(75, 40);
            this.btnModificarStock.TabIndex = 0;
            this.btnModificarStock.Text = "Modificar Stock";
            this.btnModificarStock.UseVisualStyleBackColor = true;
            this.btnModificarStock.Click += new System.EventHandler(this.btnModificarStock_Click);
            // 
            // btnOpcionAgregarProducto
            // 
            this.btnOpcionAgregarProducto.Location = new System.Drawing.Point(93, 12);
            this.btnOpcionAgregarProducto.Name = "btnOpcionAgregarProducto";
            this.btnOpcionAgregarProducto.Size = new System.Drawing.Size(75, 40);
            this.btnOpcionAgregarProducto.TabIndex = 1;
            this.btnOpcionAgregarProducto.Text = "Agregar Producto";
            this.btnOpcionAgregarProducto.UseVisualStyleBackColor = true;
            this.btnOpcionAgregarProducto.Click += new System.EventHandler(this.btnOpcionAgregarProducto_Click);
            // 
            // btnOpcionEliminar
            // 
            this.btnOpcionEliminar.Location = new System.Drawing.Point(174, 12);
            this.btnOpcionEliminar.Name = "btnOpcionEliminar";
            this.btnOpcionEliminar.Size = new System.Drawing.Size(75, 40);
            this.btnOpcionEliminar.TabIndex = 2;
            this.btnOpcionEliminar.Text = "Eliminar Producto";
            this.btnOpcionEliminar.UseVisualStyleBackColor = true;
            this.btnOpcionEliminar.Click += new System.EventHandler(this.btnOpcionEliminar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Pintura",
            "Plomeria",
            "Electrico",
            "Herramientas"});
            this.cbCategoria.Location = new System.Drawing.Point(12, 71);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 3;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(12, 55);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(0, 13);
            this.lblOpcion.TabIndex = 4;
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(12, 98);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 21);
            this.cbProducto.TabIndex = 5;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(53, 124);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(80, 20);
            this.txtStock.TabIndex = 6;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(139, 71);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(139, 98);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(139, 122);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Stock:";
            // 
            // AdministrarTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnOpcionEliminar);
            this.Controls.Add(this.btnOpcionAgregarProducto);
            this.Controls.Add(this.btnModificarStock);
            this.Name = "AdministrarTienda";
            this.Text = "AdministrarTienda";
            this.Load += new System.EventHandler(this.AdministrarTienda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarStock;
        private System.Windows.Forms.Button btnOpcionAgregarProducto;
        private System.Windows.Forms.Button btnOpcionEliminar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
    }
}