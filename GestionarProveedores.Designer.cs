namespace trabajo_de_campo_1
{
    partial class GestionarProveedores
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trabajoDeCampoDataSet = new trabajo_de_campo_1.TrabajoDeCampoDataSet();
            this.trabajoDeCampoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.ID_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomb_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direc_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoDeCampoDataSet1 = new trabajo_de_campo_1.TrabajoDeCampoDataSet1();
            this.proveedoresTableAdapter = new trabajo_de_campo_1.TrabajoDeCampoDataSet1TableAdapters.ProveedoresTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Location = new System.Drawing.Point(794, 268);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(253, 102);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Volver A Pantalla Principal";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(295, 35);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(222, 25);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarProveedor);
            this.groupBox1.Controls.Add(this.txtDirec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Proveedor";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(545, 153);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(159, 47);
            this.btnAgregarProveedor.TabIndex = 3;
            this.btnAgregarProveedor.Text = "Agregar Proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(295, 175);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(222, 25);
            this.txtDirec.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion De Proveedor";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(295, 144);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 25);
            this.txtMail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail De Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre De Proveedor";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(295, 107);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(222, 25);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI De Proveedor";
            // 
            // txtNomb
            // 
            this.txtNomb.Location = new System.Drawing.Point(295, 70);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(222, 25);
            this.txtNomb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefono De Proveedor";
            // 
            // trabajoDeCampoDataSet
            // 
            this.trabajoDeCampoDataSet.DataSetName = "TrabajoDeCampoDataSet";
            this.trabajoDeCampoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trabajoDeCampoDataSetBindingSource
            // 
            this.trabajoDeCampoDataSetBindingSource.DataSource = this.trabajoDeCampoDataSet;
            this.trabajoDeCampoDataSetBindingSource.Position = 0;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoGenerateColumns = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Proveedor,
            this.Nomb_Proveedor,
            this.Telefono,
            this.Mail_Proveedor,
            this.Direc_Proveedor});
            this.dgvProveedores.DataSource = this.proveedoresBindingSource;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 268);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 27;
            this.dgvProveedores.Size = new System.Drawing.Size(775, 180);
            this.dgvProveedores.TabIndex = 3;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.DataPropertyName = "ID_Proveedor";
            this.ID_Proveedor.HeaderText = "ID_Proveedor";
            this.ID_Proveedor.MinimumWidth = 6;
            this.ID_Proveedor.Name = "ID_Proveedor";
            this.ID_Proveedor.Width = 150;
            // 
            // Nomb_Proveedor
            // 
            this.Nomb_Proveedor.DataPropertyName = "Nomb_Proveedor";
            this.Nomb_Proveedor.HeaderText = "Nomb_Proveedor";
            this.Nomb_Proveedor.MinimumWidth = 6;
            this.Nomb_Proveedor.Name = "Nomb_Proveedor";
            this.Nomb_Proveedor.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Mail_Proveedor
            // 
            this.Mail_Proveedor.DataPropertyName = "Mail_Proveedor";
            this.Mail_Proveedor.HeaderText = "Mail_Proveedor";
            this.Mail_Proveedor.MinimumWidth = 6;
            this.Mail_Proveedor.Name = "Mail_Proveedor";
            this.Mail_Proveedor.Width = 150;
            // 
            // Direc_Proveedor
            // 
            this.Direc_Proveedor.DataPropertyName = "Direc_Proveedor";
            this.Direc_Proveedor.HeaderText = "Direc_Proveedor";
            this.Direc_Proveedor.MinimumWidth = 6;
            this.Direc_Proveedor.Name = "Direc_Proveedor";
            this.Direc_Proveedor.Width = 150;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.trabajoDeCampoDataSet1;
            // 
            // trabajoDeCampoDataSet1
            // 
            this.trabajoDeCampoDataSet1.DataSetName = "TrabajoDeCampoDataSet1";
            this.trabajoDeCampoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // GestionarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(1162, 473);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionarProveedores";
            this.Text = "GestionarProvedor";
            this.Load += new System.EventHandler(this.GestionarProvedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeCampoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.BindingSource trabajoDeCampoDataSetBindingSource;
        private TrabajoDeCampoDataSet trabajoDeCampoDataSet;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private TrabajoDeCampoDataSet1 trabajoDeCampoDataSet1;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private TrabajoDeCampoDataSet1TableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomb_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direc_Proveedor;
    }
}