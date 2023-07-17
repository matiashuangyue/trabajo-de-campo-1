namespace trabajo_de_campo_1
{
    partial class Ingresar_Stock_de_Mercaderia
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
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProduc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoProduc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioActualizado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.trabajoDeCampoDataSet4 = new trabajo_de_campo_1.TrabajoDeCampoDataSet4();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSet4TableAdapters.ProductosTableAdapter();
            this.Cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomb_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(297, 135);
            this.txtStockActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(148, 25);
            this.txtStockActual.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stock Actual";
            // 
            // txtNombreProduc
            // 
            this.txtNombreProduc.Location = new System.Drawing.Point(297, 89);
            this.txtNombreProduc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreProduc.Name = "txtNombreProduc";
            this.txtNombreProduc.ReadOnly = true;
            this.txtNombreProduc.Size = new System.Drawing.Size(148, 25);
            this.txtNombreProduc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre De Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo De Producto";
            // 
            // txtCodigoProduc
            // 
            this.txtCodigoProduc.Location = new System.Drawing.Point(297, 43);
            this.txtCodigoProduc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoProduc.Name = "txtCodigoProduc";
            this.txtCodigoProduc.ReadOnly = true;
            this.txtCodigoProduc.Size = new System.Drawing.Size(148, 25);
            this.txtCodigoProduc.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.txtPrecioActual);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStockActual);
            this.groupBox1.Controls.Add(this.txtCodigoProduc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreProduc);
            this.groupBox1.Location = new System.Drawing.Point(18, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(532, 221);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de mercaderia actual";
            // 
            // txtPrecioActual
            // 
            this.txtPrecioActual.Location = new System.Drawing.Point(297, 178);
            this.txtPrecioActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioActual.Name = "txtPrecioActual";
            this.txtPrecioActual.ReadOnly = true;
            this.txtPrecioActual.Size = new System.Drawing.Size(148, 25);
            this.txtPrecioActual.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio Actual";
            // 
            // txtPrecioActualizado
            // 
            this.txtPrecioActualizado.Location = new System.Drawing.Point(386, 68);
            this.txtPrecioActualizado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioActualizado.Name = "txtPrecioActualizado";
            this.txtPrecioActualizado.Size = new System.Drawing.Size(121, 25);
            this.txtPrecioActualizado.TabIndex = 18;
            this.txtPrecioActualizado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Precio Actualizado";
            // 
            // txtCantidadIngreso
            // 
            this.txtCantidadIngreso.Location = new System.Drawing.Point(386, 26);
            this.txtCantidadIngreso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidadIngreso.Name = "txtCantidadIngreso";
            this.txtCantidadIngreso.Size = new System.Drawing.Size(121, 25);
            this.txtCantidadIngreso.TabIndex = 16;
            this.txtCantidadIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cantidad de stock ingresado ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpVencimiento);
            this.groupBox2.Controls.Add(this.txtCantidadIngreso);
            this.groupBox2.Controls.Add(this.txtPrecioActualizado);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 255);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(532, 202);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso De Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(382, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha de Vencimiento de Mercaderia";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(54, 146);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(452, 25);
            this.dtpVencimiento.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGuardar.Location = new System.Drawing.Point(733, 311);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(377, 66);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Location = new System.Drawing.Point(733, 383);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(377, 62);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Volver A Pantalla Anterior";
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
            this.dgvProductos.Location = new System.Drawing.Point(572, 33);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 27;
            this.dgvProductos.Size = new System.Drawing.Size(538, 272);
            this.dgvProductos.TabIndex = 22;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // trabajoDeCampoDataSet4
            // 
            this.trabajoDeCampoDataSet4.DataSetName = "TrabajoDeCampoDataSet4";
            this.trabajoDeCampoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.trabajoDeCampoDataSet4;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // Cod_Producto
            // 
            this.Cod_Producto.DataPropertyName = "Cod_Producto";
            this.Cod_Producto.HeaderText = "Cod_Producto";
            this.Cod_Producto.MinimumWidth = 6;
            this.Cod_Producto.Name = "Cod_Producto";
            this.Cod_Producto.Width = 125;
            // 
            // Nomb_Producto
            // 
            this.Nomb_Producto.DataPropertyName = "Nomb_Producto";
            this.Nomb_Producto.HeaderText = "Nomb_Producto";
            this.Nomb_Producto.MinimumWidth = 6;
            this.Nomb_Producto.Name = "Nomb_Producto";
            this.Nomb_Producto.Width = 125;
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
            // Ingresar_Stock_de_Mercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(1146, 469);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ingresar_Stock_de_Mercaderia";
            this.Text = "Ingresar Nueva Stock";
            this.Load += new System.EventHandler(this.Ingresar_Stock_de_Mercaderia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProduc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoProduc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioActualizado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvProductos;
        private TrabajoDeCampoDataSet4 trabajoDeCampoDataSet4;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TrabajoDeCampoDataSet4TableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomb_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}