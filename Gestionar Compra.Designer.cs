namespace trabajo_de_campo_1
{
    partial class Gestionar_Compra
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProduc = new System.Windows.Forms.TextBox();
            this.txtCodigoProduc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.txtPrecioProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadProductoDeseado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerarPedido = new System.Windows.Forms.Button();
            this.dgvDetallePedidos = new System.Windows.Forms.DataGridView();
            this.trabajoDeCampoDataSet2 = new trabajo_de_campo_1.TrabajoDeCampoDataSet2();
            this.detallePedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallePedidosTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSet2TableAdapters.DetallePedidosTableAdapter();
            this.ID_DetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Provedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Location = new System.Drawing.Point(740, 351);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(396, 79);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Volver A Pantalla Principal";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(281, 146);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(252, 50);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBuscar.Location = new System.Drawing.Point(385, 17);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 38);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.txtPrecioActual);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStockActual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreProduc);
            this.groupBox1.Location = new System.Drawing.Point(18, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(464, 174);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de mercaderia ";
            // 
            // txtPrecioActual
            // 
            this.txtPrecioActual.Location = new System.Drawing.Point(290, 115);
            this.txtPrecioActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioActual.Name = "txtPrecioActual";
            this.txtPrecioActual.ReadOnly = true;
            this.txtPrecioActual.Size = new System.Drawing.Size(148, 25);
            this.txtPrecioActual.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre De Producto";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(290, 73);
            this.txtStockActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(148, 25);
            this.txtStockActual.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stock Actual";
            // 
            // txtNombreProduc
            // 
            this.txtNombreProduc.Location = new System.Drawing.Point(290, 26);
            this.txtNombreProduc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreProduc.Name = "txtNombreProduc";
            this.txtNombreProduc.ReadOnly = true;
            this.txtNombreProduc.Size = new System.Drawing.Size(148, 25);
            this.txtNombreProduc.TabIndex = 10;
            // 
            // txtCodigoProduc
            // 
            this.txtCodigoProduc.Location = new System.Drawing.Point(258, 19);
            this.txtCodigoProduc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoProduc.Name = "txtCodigoProduc";
            this.txtCodigoProduc.Size = new System.Drawing.Size(119, 25);
            this.txtCodigoProduc.TabIndex = 7;
            this.txtCodigoProduc.TextChanged += new System.EventHandler(this.txtCodigoProduc_TextChanged);
            this.txtCodigoProduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProduc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo De Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbProveedores);
            this.groupBox2.Controls.Add(this.txtPrecioProveedor);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCantidadProductoDeseado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(18, 263);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(599, 213);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comprar Mercaderia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Proveedor ";
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(445, 69);
            this.cbProveedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(148, 24);
            this.cbProveedores.TabIndex = 15;
            this.cbProveedores.SelectedIndexChanged += new System.EventHandler(this.cbProveedores_SelectedIndexChanged);
            // 
            // txtPrecioProveedor
            // 
            this.txtPrecioProveedor.Location = new System.Drawing.Point(445, 113);
            this.txtPrecioProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioProveedor.Name = "txtPrecioProveedor";
            this.txtPrecioProveedor.ReadOnly = true;
            this.txtPrecioProveedor.Size = new System.Drawing.Size(148, 25);
            this.txtPrecioProveedor.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio Unitario Respecto A Provedor";
            // 
            // txtCantidadProductoDeseado
            // 
            this.txtCantidadProductoDeseado.Location = new System.Drawing.Point(445, 28);
            this.txtCantidadProductoDeseado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidadProductoDeseado.Name = "txtCantidadProductoDeseado";
            this.txtCantidadProductoDeseado.Size = new System.Drawing.Size(148, 25);
            this.txtCantidadProductoDeseado.TabIndex = 12;
            this.txtCantidadProductoDeseado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProductoDeseado_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cantidad De Mercaderia Requerida";
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGenerarPedido.Location = new System.Drawing.Point(740, 263);
            this.btnGenerarPedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(396, 79);
            this.btnGenerarPedido.TabIndex = 18;
            this.btnGenerarPedido.Text = "General Pedido";
            this.btnGenerarPedido.UseVisualStyleBackColor = false;
            this.btnGenerarPedido.Click += new System.EventHandler(this.btnGenerarPedido_Click);
            // 
            // dgvDetallePedidos
            // 
            this.dgvDetallePedidos.AutoGenerateColumns = false;
            this.dgvDetallePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DetallePedido,
            this.Cod_Producto,
            this.ID_Provedor,
            this.Cantidad,
            this.Precio});
            this.dgvDetallePedidos.DataSource = this.detallePedidosBindingSource;
            this.dgvDetallePedidos.Location = new System.Drawing.Point(501, 17);
            this.dgvDetallePedidos.Name = "dgvDetallePedidos";
            this.dgvDetallePedidos.RowHeadersWidth = 51;
            this.dgvDetallePedidos.RowTemplate.Height = 27;
            this.dgvDetallePedidos.Size = new System.Drawing.Size(634, 221);
            this.dgvDetallePedidos.TabIndex = 19;
            // 
            // trabajoDeCampoDataSet2
            // 
            this.trabajoDeCampoDataSet2.DataSetName = "TrabajoDeCampoDataSet2";
            this.trabajoDeCampoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detallePedidosBindingSource
            // 
            this.detallePedidosBindingSource.DataMember = "DetallePedidos";
            this.detallePedidosBindingSource.DataSource = this.trabajoDeCampoDataSet2;
            // 
            // detallePedidosTableAdapter
            // 
            this.detallePedidosTableAdapter.ClearBeforeFill = true;
            // 
            // ID_DetallePedido
            // 
            this.ID_DetallePedido.DataPropertyName = "ID_DetallePedido";
            this.ID_DetallePedido.HeaderText = "ID_DetallePedido";
            this.ID_DetallePedido.MinimumWidth = 6;
            this.ID_DetallePedido.Name = "ID_DetallePedido";
            this.ID_DetallePedido.ReadOnly = true;
            this.ID_DetallePedido.Width = 125;
            // 
            // Cod_Producto
            // 
            this.Cod_Producto.DataPropertyName = "Cod_Producto";
            this.Cod_Producto.HeaderText = "Cod_Producto";
            this.Cod_Producto.MinimumWidth = 6;
            this.Cod_Producto.Name = "Cod_Producto";
            this.Cod_Producto.Width = 125;
            // 
            // ID_Provedor
            // 
            this.ID_Provedor.DataPropertyName = "ID_Provedor";
            this.ID_Provedor.HeaderText = "ID_Provedor";
            this.ID_Provedor.MinimumWidth = 6;
            this.ID_Provedor.Name = "ID_Provedor";
            this.ID_Provedor.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Gestionar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(1153, 519);
            this.Controls.Add(this.dgvDetallePedidos);
            this.Controls.Add(this.btnGenerarPedido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCodigoProduc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Gestionar_Compra";
            this.Text = "Gestionar Compra";
            this.Load += new System.EventHandler(this.Gestionar_Compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProduc;
        private System.Windows.Forms.TextBox txtCodigoProduc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.TextBox txtPrecioProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadProductoDeseado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.DataGridView dgvDetallePedidos;
        private TrabajoDeCampoDataSet2 trabajoDeCampoDataSet2;
        private System.Windows.Forms.BindingSource detallePedidosBindingSource;
        private TrabajoDeCampoDataSet2TableAdapters.DetallePedidosTableAdapter detallePedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Provedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}