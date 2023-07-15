using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_de_campo_1
{
    public partial class GestionarProveedores : Form
    {
        public GestionarProveedores()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VolverAPantallaPrincipal pantallaPrincipal = new VolverAPantallaPrincipal();
            pantallaPrincipal.IrAPantallaPrincipal();
            this.Close();
        }

        private void GestionarProvedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet1.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.trabajoDeCampoDataSet1.Proveedores);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDNI.Text) ||
                 string.IsNullOrEmpty(txtNomb.Text) ||
                 string.IsNullOrEmpty(txtTelefono.Text) ||
                 string.IsNullOrEmpty(txtMail.Text) ||
                  string.IsNullOrEmpty(txtDirec.Text)
                 )
            {
                MessageBox.Show("Por favor, completa todos los datos.");
            }
            else
            {
                Controladora.ControlGestionarProveedores AgregarProveedor = new Controladora.ControlGestionarProveedores();
                if (AgregarProveedor.PasarProveedor(txtDNI.Text, txtNomb.Text,txtTelefono.Text, txtMail.Text,txtDirec.Text) == false)
                {
                    MessageBox.Show("el Proveedor ya existe o mail no es valido!");
                }
                else
                {
                    MessageBox.Show("Proveedor agregado con exito ");
                    this.proveedoresTableAdapter.Fill(this.trabajoDeCampoDataSet1.Proveedores);
                    dgvProveedores.Refresh();
                }
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            string DNI = dgvProveedores.Rows[indiceFila].Cells["ID_Proveedor"].Value.ToString();
            string Nombre = dgvProveedores.Rows[indiceFila].Cells["Nomb_Proveedor"].Value.ToString();
            string Telefono = dgvProveedores.Rows[indiceFila].Cells["Telefono"].Value.ToString();
            string Mail = dgvProveedores.Rows[indiceFila].Cells["Mail_Proveedor"].Value.ToString();
            string Direccion = dgvProveedores.Rows[indiceFila].Cells["Direc_Proveedor"].Value.ToString();
            // Llenar los TextBox con los valores obtenidos
            txtDNI.Text = DNI;
            txtNomb.Text = Nombre;
            txtTelefono.Text = Telefono;
            txtMail.Text = Mail;
            txtDirec.Text = Direccion;
        }
    }
}
