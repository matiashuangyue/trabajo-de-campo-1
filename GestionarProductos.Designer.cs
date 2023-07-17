namespace trabajo_de_campo_1
{
    partial class GestionarProductos
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
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomb_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoDeCampoDataSet = new trabajo_de_campo_1.TrabajoDeCampoDataSet();
            this.productosTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSetTableAdapters.ProductosTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(243, 46);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(227, 25);
            this.txtCodProducto.TabIndex = 0;
            this.txtCodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProducto_KeyPress);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(243, 152);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(227, 25);
            this.txtPrecioProducto.TabIndex = 1;
            this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProducto_KeyPress);
            // 
            // txtNombProducto
            // 
            this.txtNombProducto.Location = new System.Drawing.Point(243, 101);
            this.txtNombProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombProducto.Name = "txtNombProducto";
            this.txtNombProducto.Size = new System.Drawing.Size(227, 25);
            this.txtNombProducto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo De Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Location = new System.Drawing.Point(955, 378);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(222, 77);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Volver A Pagina Anterio";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Producto,
            this.Nomb_Producto,
            this.Precio,
            this.Stock});
            this.dgvProductos.DataSource = this.productosBindingSource;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 27;
            this.dgvProductos.Size = new System.Drawing.Size(633, 346);
            this.dgvProductos.TabIndex = 7;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick_1);
            // 
            // Cod_Producto
            // 
            this.Cod_Producto.DataPropertyName = "Cod_Producto";
            this.Cod_Producto.HeaderText = "Cod_Producto";
            this.Cod_Producto.MinimumWidth = 6;
            this.Cod_Producto.Name = "Cod_Producto";
            this.Cod_Producto.Width = 175;
            // 
            // Nomb_Producto
            // 
            this.Nomb_Producto.DataPropertyName = "Nomb_Producto";
            this.Nomb_Producto.HeaderText = "Nomb_Producto";
            this.Nomb_Producto.MinimumWidth = 6;
            this.Nomb_Producto.Name = "Nomb_Producto";
            this.Nomb_Producto.Width = 175;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 125;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.trabajoDeCampoDataSet;
            // 
            // trabajoDeCampoDataSet
            // 
            this.trabajoDeCampoDataSet.DataSetName = "TrabajoDeCampoDataSet";
            this.trabajoDeCampoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock : ";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(243, 209);
            this.txtStockProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(227, 25);
            this.txtStockProducto.TabIndex = 9;
            this.txtStockProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockProducto_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStockProducto);
            this.groupBox1.Controls.Add(this.txtCodProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioProducto);
            this.groupBox1.Controls.Add(this.txtNombProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(725, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 264);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Productos";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAgregarProducto.Location = new System.Drawing.Point(719, 378);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(222, 77);
            this.btnAgregarProducto.TabIndex = 11;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // GestionarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(1200, 480);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionarProductos";
            this.Text = "GestionarProducto";
            this.Load += new System.EventHandler(this.GestionarProducto_Load);
            this.Click += new System.EventHandler(this.GestionarProducto_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvProductos;
        private TrabajoDeCampoDataSet trabajoDeCampoDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TrabajoDeCampoDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomb_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}