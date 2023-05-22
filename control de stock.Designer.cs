namespace trabajo_de_campo_1
{
    partial class control_de_stock
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoProduc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProduc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnIngresarStock = new System.Windows.Forms.Button();
            this.FechaVencimiento = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(485, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(236, 46);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtCodigoProduc
            // 
            this.txtCodigoProduc.Location = new System.Drawing.Point(251, 30);
            this.txtCodigoProduc.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCodigoProduc.Name = "txtCodigoProduc";
            this.txtCodigoProduc.Size = new System.Drawing.Size(148, 25);
            this.txtCodigoProduc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo De Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre De Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombreProduc
            // 
            this.txtNombreProduc.Location = new System.Drawing.Point(256, 23);
            this.txtNombreProduc.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombreProduc.Name = "txtNombreProduc";
            this.txtNombreProduc.Size = new System.Drawing.Size(148, 25);
            this.txtNombreProduc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock Actual";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 25);
            this.textBox2.TabIndex = 6;
            // 
            // btnIngresarStock
            // 
            this.btnIngresarStock.BackColor = System.Drawing.Color.Cornsilk;
            this.btnIngresarStock.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarStock.Location = new System.Drawing.Point(52, 360);
            this.btnIngresarStock.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnIngresarStock.Name = "btnIngresarStock";
            this.btnIngresarStock.Size = new System.Drawing.Size(365, 56);
            this.btnIngresarStock.TabIndex = 7;
            this.btnIngresarStock.Text = "Ingresar Nueva Stock de Mercaderia";
            this.btnIngresarStock.UseVisualStyleBackColor = false;
            this.btnIngresarStock.Click += new System.EventHandler(this.btnIngresarStock_Click);
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.BackColor = System.Drawing.Color.Cornsilk;
            this.FechaVencimiento.FormattingEnabled = true;
            this.FechaVencimiento.ItemHeight = 16;
            this.FechaVencimiento.Location = new System.Drawing.Point(13, 157);
            this.FechaVencimiento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(612, 100);
            this.FechaVencimiento.TabIndex = 8;
            this.FechaVencimiento.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(464, 360);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(365, 56);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Volver A Pantalla Principal";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPrecioActual
            // 
            this.txtPrecioActual.Location = new System.Drawing.Point(256, 109);
            this.txtPrecioActual.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPrecioActual.Name = "txtPrecioActual";
            this.txtPrecioActual.Size = new System.Drawing.Size(148, 25);
            this.txtPrecioActual.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio Actual";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtPrecioActual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreProduc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FechaVencimiento);
            this.groupBox1.Location = new System.Drawing.Point(52, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 271);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Producto";
            // 
            // control_de_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(929, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnIngresarStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoProduc);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "control_de_stock";
            this.Text = "Control De Stock";
            this.Load += new System.EventHandler(this.control_de_stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoProduc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProduc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnIngresarStock;
        private System.Windows.Forms.ListBox FechaVencimiento;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}