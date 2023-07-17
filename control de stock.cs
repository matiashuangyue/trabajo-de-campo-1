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
    public partial class control_de_stock : Form
    {
        string Codigo= "";
        string Nombre = "";
        string Stock= "";
        string Precio = "";
        public control_de_stock()
        {
            InitializeComponent();
        }

        public void IngresarNuevaStock()
        {
            Ingresar_Stock_de_Mercaderia IngresarNuevaStock = new Ingresar_Stock_de_Mercaderia(Codigo,Nombre,Precio,Stock);
            IngresarNuevaStock.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void control_de_stock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet3.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.trabajoDeCampoDataSet3.Productos);
            CenterToScreen();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VolverAPantallaPrincipal pantallaPrincipal = new VolverAPantallaPrincipal();
            pantallaPrincipal.IrAPantallaPrincipal();
            this.Close();
        }

        private void btnIngresarStock_Click(object sender, EventArgs e)
        {
            Controladora.ControlGestionarCompras gestionarCompras = new Controladora.ControlGestionarCompras();
            if (gestionarCompras.buscarProducto(txtCodigoProduc.Text, out string NombreProducto, out string PrecioActual, out string StockActual) == false)
            {
                MessageBox.Show("El producto con el código ingresado no se encuentra en la base de datos.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombreProduc.Text))
                {
                    MessageBox.Show("Presiona boton de buscar antes de ingresar stock de un  producto deseado porfavor");
                }
                else
                {
                    IngresarNuevaStock();
                }
                
            }
           
                
        }

        private void txtCodigoProduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Cancelar el evento del teclado
            }

            // Permitir el signo de menos solo en la primera posición
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') >= 0)
            {
                e.Handled = true; // Cancelar el evento del teclado
            }
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoProduc.Text))
            {
                MessageBox.Show("ingresar codigo de producto deseado porfavor");
            }
            else
            {
                Controladora.ControlGestionarCompras gestionarCompras = new Controladora.ControlGestionarCompras();
                if (gestionarCompras.buscarProducto(txtCodigoProduc.Text, out string NombreProducto, out string PrecioActual, out string StockActual) == false)
                {
                    MessageBox.Show("El producto con el código ingresado no se encuentra en la base de datos.");
                }
                else
                {

                    txtNombreProduc.Text = NombreProducto;
                    txtPrecioActual.Text = PrecioActual;
                    txtStockActual.Text = StockActual;
                    Codigo=txtCodigoProduc.Text;
                    Nombre = txtNombreProduc.Text;
                    Precio = txtPrecioActual.Text;
                    Stock = txtStockActual.Text;
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            string CodigoProducto = dgvProductos.Rows[indiceFila].Cells["Cod_Producto"].Value.ToString();
            string NombreProducto = dgvProductos.Rows[indiceFila].Cells["Nomb_Producto"].Value.ToString();
            string PrecioProducto = dgvProductos.Rows[indiceFila].Cells["PrecioActual"].Value.ToString();
            string StockProducto = dgvProductos.Rows[indiceFila].Cells["StockActual"].Value.ToString();
            // Llenar los TextBox con los valores obtenidos
            txtCodigoProduc.Text = CodigoProducto;
            txtNombreProduc.Text = NombreProducto;
            txtPrecioActual.Text = PrecioProducto;
            txtStockActual.Text = StockProducto;
            Codigo = txtCodigoProduc.Text;
            Nombre = txtNombreProduc.Text;
            Precio = txtPrecioActual.Text;
            Stock = txtStockActual.Text;
        }
    }
}
