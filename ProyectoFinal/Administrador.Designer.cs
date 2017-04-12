namespace ProyectoFinal
{
    partial class Administrador
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
            this.btnIngresoTienda = new System.Windows.Forms.Button();
            this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.btnAdministrarTienda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresoTienda
            // 
            this.btnIngresoTienda.Location = new System.Drawing.Point(12, 12);
            this.btnIngresoTienda.Name = "btnIngresoTienda";
            this.btnIngresoTienda.Size = new System.Drawing.Size(99, 36);
            this.btnIngresoTienda.TabIndex = 0;
            this.btnIngresoTienda.Text = "Ingresar a Tienda";
            this.btnIngresoTienda.UseVisualStyleBackColor = true;
            this.btnIngresoTienda.Click += new System.EventHandler(this.btnIngresoTienda_Click);
            // 
            // btnAdministrarUsuarios
            // 
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(117, 12);
            this.btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            this.btnAdministrarUsuarios.Size = new System.Drawing.Size(99, 36);
            this.btnAdministrarUsuarios.TabIndex = 1;
            this.btnAdministrarUsuarios.Text = "Administrar usuarios";
            this.btnAdministrarUsuarios.UseVisualStyleBackColor = true;
            this.btnAdministrarUsuarios.Click += new System.EventHandler(this.btnAdministrarUsuarios_Click);
            // 
            // btnAdministrarTienda
            // 
            this.btnAdministrarTienda.Location = new System.Drawing.Point(12, 54);
            this.btnAdministrarTienda.Name = "btnAdministrarTienda";
            this.btnAdministrarTienda.Size = new System.Drawing.Size(99, 36);
            this.btnAdministrarTienda.TabIndex = 2;
            this.btnAdministrarTienda.Text = "Administrar Tienda";
            this.btnAdministrarTienda.UseVisualStyleBackColor = true;
            this.btnAdministrarTienda.Click += new System.EventHandler(this.btnAdministrarTienda_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(117, 54);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 102);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdministrarTienda);
            this.Controls.Add(this.btnAdministrarUsuarios);
            this.Controls.Add(this.btnIngresoTienda);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoTienda;
        private System.Windows.Forms.Button btnAdministrarUsuarios;
        private System.Windows.Forms.Button btnAdministrarTienda;
        private System.Windows.Forms.Button btnSalir;
    }
}