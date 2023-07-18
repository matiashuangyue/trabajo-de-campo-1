namespace trabajo_de_campo_1
{
    partial class InfoTablas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.trabajoDeCampoDataSet6 = new trabajo_de_campo_1.TrabajoDeCampoDataSet6();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSet6TableAdapters.UsuariosTableAdapter();
            this.iDUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajoDeCampoDataSet7 = new trabajo_de_campo_1.TrabajoDeCampoDataSet7();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSet7TableAdapters.ProveedoresTableAdapter();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajoDeCampoDataSet8 = new trabajo_de_campo_1.TrabajoDeCampoDataSet8();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSet8TableAdapters.ProductosTableAdapter();
            this.codProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajoDeCampoDataSet10 = new trabajo_de_campo_1.TrabajoDeCampoDataSet10();
            this.detallePedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallePedidosTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSet10TableAdapters.DetallePedidosTableAdapter();
            this.iDDetallePedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProveedorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProductoDataGridViewTextBoxColumn,
            this.nombProductoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(554, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProveedorDataGridViewTextBoxColumn,
            this.nombProveedorDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.mailProveedorDataGridViewTextBoxColumn,
            this.direcProveedorDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.proveedoresBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(588, 12);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(556, 198);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDetallePedidoDataGridViewTextBoxColumn,
            this.codProductoDataGridViewTextBoxColumn1,
            this.iDProveedorDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.detallePedidosBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(588, 216);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(556, 198);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsuarioDataGridViewTextBoxColumn,
            this.nombUsuarioDataGridViewTextBoxColumn,
            this.contraseñaUsuarioDataGridViewTextBoxColumn,
            this.mailUsuarioDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.usuariosBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(13, 12);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.Size = new System.Drawing.Size(554, 198);
            this.dataGridView4.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(392, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(372, 47);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Volver A Pantalla Principal";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // trabajoDeCampoDataSet6
            // 
            this.trabajoDeCampoDataSet6.DataSetName = "TrabajoDeCampoDataSet6";
            this.trabajoDeCampoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.trabajoDeCampoDataSet6;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // iDUsuarioDataGridViewTextBoxColumn
            // 
            this.iDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.HeaderText = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDUsuarioDataGridViewTextBoxColumn.Name = "iDUsuarioDataGridViewTextBoxColumn";
            this.iDUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombUsuarioDataGridViewTextBoxColumn
            // 
            this.nombUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Nomb_Usuario";
            this.nombUsuarioDataGridViewTextBoxColumn.HeaderText = "Nomb_Usuario";
            this.nombUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombUsuarioDataGridViewTextBoxColumn.Name = "nombUsuarioDataGridViewTextBoxColumn";
            this.nombUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // contraseñaUsuarioDataGridViewTextBoxColumn
            // 
            this.contraseñaUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Contraseña_Usuario";
            this.contraseñaUsuarioDataGridViewTextBoxColumn.HeaderText = "Contraseña_Usuario";
            this.contraseñaUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contraseñaUsuarioDataGridViewTextBoxColumn.Name = "contraseñaUsuarioDataGridViewTextBoxColumn";
            this.contraseñaUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailUsuarioDataGridViewTextBoxColumn
            // 
            this.mailUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Mail_Usuario";
            this.mailUsuarioDataGridViewTextBoxColumn.HeaderText = "Mail_Usuario";
            this.mailUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailUsuarioDataGridViewTextBoxColumn.Name = "mailUsuarioDataGridViewTextBoxColumn";
            this.mailUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // trabajoDeCampoDataSet7
            // 
            this.trabajoDeCampoDataSet7.DataSetName = "TrabajoDeCampoDataSet7";
            this.trabajoDeCampoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.trabajoDeCampoDataSet7;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "ID_Proveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "ID_Proveedor";
            this.iDProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombProveedorDataGridViewTextBoxColumn
            // 
            this.nombProveedorDataGridViewTextBoxColumn.DataPropertyName = "Nomb_Proveedor";
            this.nombProveedorDataGridViewTextBoxColumn.HeaderText = "Nomb_Proveedor";
            this.nombProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombProveedorDataGridViewTextBoxColumn.Name = "nombProveedorDataGridViewTextBoxColumn";
            this.nombProveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailProveedorDataGridViewTextBoxColumn
            // 
            this.mailProveedorDataGridViewTextBoxColumn.DataPropertyName = "Mail_Proveedor";
            this.mailProveedorDataGridViewTextBoxColumn.HeaderText = "Mail_Proveedor";
            this.mailProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailProveedorDataGridViewTextBoxColumn.Name = "mailProveedorDataGridViewTextBoxColumn";
            this.mailProveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // direcProveedorDataGridViewTextBoxColumn
            // 
            this.direcProveedorDataGridViewTextBoxColumn.DataPropertyName = "Direc_Proveedor";
            this.direcProveedorDataGridViewTextBoxColumn.HeaderText = "Direc_Proveedor";
            this.direcProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direcProveedorDataGridViewTextBoxColumn.Name = "direcProveedorDataGridViewTextBoxColumn";
            this.direcProveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // trabajoDeCampoDataSet8
            // 
            this.trabajoDeCampoDataSet8.DataSetName = "TrabajoDeCampoDataSet8";
            this.trabajoDeCampoDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.trabajoDeCampoDataSet8;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // codProductoDataGridViewTextBoxColumn
            // 
            this.codProductoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Producto";
            this.codProductoDataGridViewTextBoxColumn.HeaderText = "Cod_Producto";
            this.codProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codProductoDataGridViewTextBoxColumn.Name = "codProductoDataGridViewTextBoxColumn";
            this.codProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombProductoDataGridViewTextBoxColumn
            // 
            this.nombProductoDataGridViewTextBoxColumn.DataPropertyName = "Nomb_Producto";
            this.nombProductoDataGridViewTextBoxColumn.HeaderText = "Nomb_Producto";
            this.nombProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombProductoDataGridViewTextBoxColumn.Name = "nombProductoDataGridViewTextBoxColumn";
            this.nombProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // trabajoDeCampoDataSet10
            // 
            this.trabajoDeCampoDataSet10.DataSetName = "TrabajoDeCampoDataSet10";
            this.trabajoDeCampoDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detallePedidosBindingSource
            // 
            this.detallePedidosBindingSource.DataMember = "DetallePedidos";
            this.detallePedidosBindingSource.DataSource = this.trabajoDeCampoDataSet10;
            // 
            // detallePedidosTableAdapter
            // 
            this.detallePedidosTableAdapter.ClearBeforeFill = true;
            // 
            // iDDetallePedidoDataGridViewTextBoxColumn
            // 
            this.iDDetallePedidoDataGridViewTextBoxColumn.DataPropertyName = "ID_DetallePedido";
            this.iDDetallePedidoDataGridViewTextBoxColumn.HeaderText = "ID_DetallePedido";
            this.iDDetallePedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDetallePedidoDataGridViewTextBoxColumn.Name = "iDDetallePedidoDataGridViewTextBoxColumn";
            this.iDDetallePedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDetallePedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codProductoDataGridViewTextBoxColumn1
            // 
            this.codProductoDataGridViewTextBoxColumn1.DataPropertyName = "Cod_Producto";
            this.codProductoDataGridViewTextBoxColumn1.HeaderText = "Cod_Producto";
            this.codProductoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codProductoDataGridViewTextBoxColumn1.Name = "codProductoDataGridViewTextBoxColumn1";
            this.codProductoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // iDProveedorDataGridViewTextBoxColumn1
            // 
            this.iDProveedorDataGridViewTextBoxColumn1.DataPropertyName = "ID_Proveedor";
            this.iDProveedorDataGridViewTextBoxColumn1.HeaderText = "ID_Proveedor";
            this.iDProveedorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDProveedorDataGridViewTextBoxColumn1.Name = "iDProveedorDataGridViewTextBoxColumn1";
            this.iDProveedorDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.Width = 125;
            // 
            // InfoTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(1162, 473);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Headline R", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InfoTablas";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.Tablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnBack;
        private TrabajoDeCampoDataSet6 trabajoDeCampoDataSet6;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private TrabajoDeCampoDataSet6TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailUsuarioDataGridViewTextBoxColumn;
        private TrabajoDeCampoDataSet7 trabajoDeCampoDataSet7;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private TrabajoDeCampoDataSet7TableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcProveedorDataGridViewTextBoxColumn;
        private TrabajoDeCampoDataSet8 trabajoDeCampoDataSet8;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TrabajoDeCampoDataSet8TableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private TrabajoDeCampoDataSet10 trabajoDeCampoDataSet10;
        private System.Windows.Forms.BindingSource detallePedidosBindingSource;
        private TrabajoDeCampoDataSet10TableAdapters.DetallePedidosTableAdapter detallePedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDetallePedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
    }
}