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
    public partial class Ingresar_Stock_de_Mercaderia : Form
    {
        public Ingresar_Stock_de_Mercaderia(string codigo,string nombre,string precio,string stock)
        {
            InitializeComponent();
            txtCodigoProduc.Text = codigo;
            txtNombreProduc.Text = nombre;
            txtPrecioActual.Text = precio;
            txtStockActual.Text = stock;
        }

        public void VolverAPantallaAnterior()
        {
            control_de_stock ControlDeStock = new control_de_stock();
            ControlDeStock.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VolverAPantallaAnterior();
        }

        private void Ingresar_Stock_de_Mercaderia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet4.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.trabajoDeCampoDataSet4.Productos);
            CenterToScreen();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int stock = 0;
            if (string.IsNullOrEmpty(txtCodigoProduc.Text) ||
                string.IsNullOrEmpty(txtNombreProduc.Text) ||
                string.IsNullOrEmpty(txtPrecioActual.Text) ||
                string.IsNullOrEmpty(txtStockActual.Text) ||
                string.IsNullOrEmpty(txtCantidadIngreso.Text) ||
                 string.IsNullOrEmpty(txtPrecioActualizado.Text)
                )
            {
                MessageBox.Show("Porfavor Completar los datos");
            }
            else
            {
                stock = int.Parse(txtStockActual.Text) + int.Parse(txtCantidadIngreso.Text);
                string StockActualizado=stock.ToString();
                Controladora.ControlIngresoStock controlIngresoStock = new Controladora.ControlIngresoStock();
                if (controlIngresoStock.ActualizarStockPrecio(txtCodigoProduc.Text, StockActualizado, txtPrecioActualizado.Text) == false)
                {

                    MessageBox.Show("error en sql");
                }
                else
                {
                    MessageBox.Show("Stock y precio de producto:"+ txtNombreProduc.Text+" actualizado con exito");
                    this.productosTableAdapter.Fill(this.trabajoDeCampoDataSet4.Productos);
                    dgvProductos.Refresh();
                    txtStockActual.Text= StockActualizado;
                    txtPrecioActual.Text = txtPrecioActualizado.Text;
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            string CodigoProducto = dgvProductos.Rows[indiceFila].Cells["Cod_Producto"].Value.ToString();
            string NombreProducto = dgvProductos.Rows[indiceFila].Cells["Nomb_Producto"].Value.ToString();
            string PrecioProducto = dgvProductos.Rows[indiceFila].Cells["Precio"].Value.ToString();
            string StockProducto = dgvProductos.Rows[indiceFila].Cells["Stock"].Value.ToString();
            // Llenar los TextBox con los valores obtenidos
            txtCodigoProduc.Text = CodigoProducto;
            txtNombreProduc.Text = NombreProducto;
            txtPrecioActual.Text = PrecioProducto;
            txtStockActual.Text = StockProducto;
        }
    }
}
