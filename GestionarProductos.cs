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
    public partial class GestionarProductos : Form
    {
        public GestionarProductos()
        {
            InitializeComponent();
          
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            VolverAPantallaPrincipal pantallaPrincipal = new VolverAPantallaPrincipal();
            pantallaPrincipal.IrAPantallaPrincipal();
            this.Close();
        }

        private void GestionarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.trabajoDeCampoDataSet.Productos);

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodProducto.Text) ||
                 string.IsNullOrEmpty(txtNombProducto.Text) ||
                 string.IsNullOrEmpty(txtPrecioProducto.Text) ||
                  string.IsNullOrEmpty(txtStockProducto.Text)
                 )
            {
                MessageBox.Show("Por favor, completa todos los datos.");
            }
            else
            {       Controladora.ControlGestionarProductos AgregarProduxcto = new Controladora.ControlGestionarProductos();
                   if (AgregarProduxcto.PasarProducto(txtCodProducto.Text, txtNombProducto.Text,txtPrecioProducto.Text, txtStockProducto.Text)==false)
                    {
                        MessageBox.Show("el producto ya existe");
                    }
                    else
                    {
                    MessageBox.Show("Producto agregado con exito ");
                    this.productosTableAdapter.Fill(this.trabajoDeCampoDataSet.Productos);
                    dgvProductos.Refresh();
                    }   
            }
           
        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            string CodigoProducto =dgvProductos.Rows[indiceFila].Cells["Cod_Producto"].Value.ToString();
            string NombreProducto = dgvProductos.Rows[indiceFila].Cells["Nomb_Producto"].Value.ToString();
                 string PrecioProducto = dgvProductos.Rows[indiceFila].Cells["Precio"].Value.ToString();
            string StockProducto = dgvProductos.Rows[indiceFila].Cells["Stock"].Value.ToString();
            // Llenar los TextBox con los valores obtenidos
            txtCodProducto.Text = CodigoProducto;
                txtNombProducto.Text = NombreProducto;
                txtPrecioProducto.Text = PrecioProducto;
                txtStockProducto.Text = StockProducto;
        }

        private void GestionarProducto_Click(object sender, EventArgs e)
        {


        }
    }
    public class VolverAPantallaPrincipal
    {
        public void IrAPantallaPrincipal()
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            
        } 
    }
}
