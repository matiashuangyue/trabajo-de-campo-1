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
            this.btnGestionarCompra = new System.Windows.Forms.Button();
            this.btnConsultarBD = new System.Windows.Forms.Button();
            this.btnGestionarProducto = new System.Windows.Forms.Button();
            this.btnGestionarProvedor = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnControlStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionarCompra
            // 
            this.btnGestionarCompra.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGestionarCompra.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGestionarCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGestionarCompra.Location = new System.Drawing.Point(45, 260);
            this.btnGestionarCompra.Name = "btnGestionarCompra";
            this.btnGestionarCompra.Size = new System.Drawing.Size(319, 62);
            this.btnGestionarCompra.TabIndex = 0;
            this.btnGestionarCompra.Text = "Gestionar Compra";
            this.btnGestionarCompra.UseVisualStyleBackColor = false;
            this.btnGestionarCompra.Click += new System.EventHandler(this.btnGestionarCompra_Click);
            // 
            // btnConsultarBD
            // 
            this.btnConsultarBD.BackColor = System.Drawing.Color.Cornsilk;
            this.btnConsultarBD.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConsultarBD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarBD.Location = new System.Drawing.Point(45, 368);
            this.btnConsultarBD.Name = "btnConsultarBD";
            this.btnConsultarBD.Size = new System.Drawing.Size(319, 62);
            this.btnConsultarBD.TabIndex = 1;
            this.btnConsultarBD.Text = "Consultar Al Base De Datos";
            this.btnConsultarBD.UseVisualStyleBackColor = false;
            this.btnConsultarBD.Click += new System.EventHandler(this.btnSolicitarInforme_Click);
            // 
            // btnGestionarProducto
            // 
            this.btnGestionarProducto.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGestionarProducto.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGestionarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGestionarProducto.Location = new System.Drawing.Point(45, 32);
            this.btnGestionarProducto.Name = "btnGestionarProducto";
            this.btnGestionarProducto.Size = new System.Drawing.Size(319, 62);
            this.btnGestionarProducto.TabIndex = 2;
            this.btnGestionarProducto.Text = "Gestionar Producto";
            this.btnGestionarProducto.UseVisualStyleBackColor = false;
            this.btnGestionarProducto.Click += new System.EventHandler(this.btnGestionarProducto_Click);
            // 
            // btnGestionarProvedor
            // 
            this.btnGestionarProvedor.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGestionarProvedor.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGestionarProvedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGestionarProvedor.Location = new System.Drawing.Point(45, 146);
            this.btnGestionarProvedor.Name = "btnGestionarProvedor";
            this.btnGestionarProvedor.Size = new System.Drawing.Size(319, 62);
            this.btnGestionarProvedor.TabIndex = 3;
            this.btnGestionarProvedor.Text = "Gestionar Provedor";
            this.btnGestionarProvedor.UseVisualStyleBackColor = false;
            this.btnGestionarProvedor.Click += new System.EventHandler(this.btnGestionarProvedor_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(447, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(319, 62);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Salir";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnControlStock
            // 
            this.btnControlStock.BackColor = System.Drawing.Color.Cornsilk;
            this.btnControlStock.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnControlStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnControlStock.Location = new System.Drawing.Point(447, 32);
            this.btnControlStock.Name = "btnControlStock";
            this.btnControlStock.Size = new System.Drawing.Size(319, 62);
            this.btnControlStock.TabIndex = 5;
            this.btnControlStock.Text = "Control de stock ";
            this.btnControlStock.UseVisualStyleBackColor = false;
            this.btnControlStock.Click += new System.EventHandler(this.btnControlStock_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btnControlStock);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGestionarProvedor);
            this.Controls.Add(this.btnGestionarProducto);
            this.Controls.Add(this.btnConsultarBD);
            this.Controls.Add(this.btnGestionarCompra);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarCompra;
        private System.Windows.Forms.Button btnConsultarBD;
        private System.Windows.Forms.Button btnGestionarProducto;
        private System.Windows.Forms.Button btnGestionarProvedor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnControlStock;
    }
}