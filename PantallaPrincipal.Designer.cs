namespace trabajo_de_campo_1
{
    partial class PantallaPrincipal
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
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnGestionarProducto = new System.Windows.Forms.Button();
            this.btnGestionarProvedor = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(86, 246);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(315, 65);
            this.btnCompra.TabIndex = 0;
            this.btnCompra.Text = "Solicitud De Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(86, 317);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(315, 65);
            this.btnInforme.TabIndex = 1;
            this.btnInforme.Text = "Solicitar Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            // 
            // btnGestionarProducto
            // 
            this.btnGestionarProducto.Location = new System.Drawing.Point(86, 22);
            this.btnGestionarProducto.Name = "btnGestionarProducto";
            this.btnGestionarProducto.Size = new System.Drawing.Size(315, 65);
            this.btnGestionarProducto.TabIndex = 2;
            this.btnGestionarProducto.Text = "Gestionar Producto";
            this.btnGestionarProducto.UseVisualStyleBackColor = true;
            this.btnGestionarProducto.Click += new System.EventHandler(this.btnGestionarProducto_Click);
            // 
            // btnGestionarProvedor
            // 
            this.btnGestionarProvedor.Location = new System.Drawing.Point(86, 93);
            this.btnGestionarProvedor.Name = "btnGestionarProvedor";
            this.btnGestionarProvedor.Size = new System.Drawing.Size(315, 65);
            this.btnGestionarProvedor.TabIndex = 3;
            this.btnGestionarProvedor.Text = "Gestionar Provedor";
            this.btnGestionarProvedor.UseVisualStyleBackColor = true;
            this.btnGestionarProvedor.Click += new System.EventHandler(this.btnGestionarProvedor_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(640, 338);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 43);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Salir";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGestionarProvedor);
            this.Controls.Add(this.btnGestionarProducto);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnCompra);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnGestionarProducto;
        private System.Windows.Forms.Button btnGestionarProvedor;
        private System.Windows.Forms.Button btnBack;
    }
}