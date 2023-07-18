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
            this.components = new System.ComponentModel.Container();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoProduc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProduc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.btnIngresarStock = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomb_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoDeCampoDataSet3 = new trabajo_de_campo_1.TrabajoDeCampoDataSet3();
            this.productosTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSet3TableAdapters.ProductosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(593, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(236, 46);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoProduc
            // 
            this.txtCodigoProduc.Location = new System.Drawing.Point(308, 30);
            this.txtCodigoProduc.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCodigoProduc.Name = "txtCodigoProduc";
            this.txtCodigoProduc.Size = new System.Drawing.Size(148, 25);
            this.txtCodigoProduc.TabIndex = 1;
            this.txtCodigoProduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProduc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 33);
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
            this.txtNombreProduc.ReadOnly = true;
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
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(256, 70);
            this.txtStockActual.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(148, 25);
            this.txtStockActual.TabIndex = 6;
            // 
            // btnIngresarStock
            // 
            this.btnIngresarStock.BackColor = System.Drawing.Color.Cornsilk;
            this.btnIngresarStock.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarStock.Location = new System.Drawing.Point(52, 360);
            this.btnIngresarStock.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnIngresarStock.Name = "btnIngresarStock";
            this.btnIngresarStock.Size = new System.Drawing.Size(365, 84);
            this.btnIngresarStock.TabIndex = 7;
            this.btnIngresarStock.Text = "Ingresar Nueva Stock de Mercaderia";
            this.btnIngresarStock.UseVisualStyleBackColor = false;
            this.btnIngresarStock.Click += new System.EventHandler(this.btnIngresarStock_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(464, 360);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(365, 84);
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
            this.txtPrecioActual.ReadOnly = true;
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
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Controls.Add(this.txtStockActual);
            this.groupBox1.Controls.Add(this.txtPrecioActual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreProduc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(52, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 271);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Producto";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Producto,
            this.Nomb_Producto,
            this.PrecioActual,
            this.StockActual});
            this.dgvProductos.DataSource = this.productosBindingSource;
            this.dgvProductos.Location = new System.Drawing.Point(6, 139);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 27;
            this.dgvProductos.Size = new System.Drawing.Size(657, 126);
            this.dgvProductos.TabIndex = 12;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // Cod_Producto
            // 
            this.Cod_Producto.DataPropertyName = "Cod_Producto";
            this.Cod_Producto.HeaderText = "Cod_Producto";
            this.Cod_Producto.MinimumWidth = 6;
            this.Cod_Producto.Name = "Cod_Producto";
            this.Cod_Producto.Width = 150;
            // 
            // Nomb_Producto
            // 
            this.Nomb_Producto.DataPropertyName = "Nomb_Producto";
            this.Nomb_Producto.HeaderText = "Nomb_Producto";
            this.Nomb_Producto.MinimumWidth = 6;
            this.Nomb_Producto.Name = "Nomb_Producto";
            this.Nomb_Producto.Width = 150;
            // 
            // PrecioActual
            // 
            this.PrecioActual.DataPropertyName = "Precio";
            this.PrecioActual.HeaderText = "Precio";
            this.PrecioActual.MinimumWidth = 6;
            this.PrecioActual.Name = "PrecioActual";
            this.PrecioActual.Width = 150;
            // 
            // StockActual
            // 
            this.StockActual.DataPropertyName = "Stock";
            this.StockActual.HeaderText = "Stock";
            this.StockActual.MinimumWidth = 6;
            this.StockActual.Name = "StockActual";
            this.StockActual.Width = 150;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.trabajoDeCampoDataSet3;
            // 
            // trabajoDeCampoDataSet3
            // 
            this.trabajoDeCampoDataSet3.DataSetName = "TrabajoDeCampoDataSet3";
            this.trabajoDeCampoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // control_de_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(1162, 473);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet3)).EndInit();
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
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Button btnIngresarStock;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private TrabajoDeCampoDataSet3 trabajoDeCampoDataSet3;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TrabajoDeCampoDataSet3TableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomb_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
    }
}