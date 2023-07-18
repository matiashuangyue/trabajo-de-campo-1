using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace trabajo_de_campo_1
{
    public partial class Gestionar_Compra : Form
    {
        private string cnn = "Data Source =DESKTOP-2F4NVAS\\YUESERVER; Initial Catalog = TrabajoDeCampo; Integrated Security= True";

        
        private void LoadProveedorNames()
        {
            // Limpiar el ComboBox antes de cargar los datos
            cbProveedores.Items.Clear();

            // Consulta SQL para obtener los nombres de los proveedores
            string query = "SELECT Nomb_Proveedor FROM Proveedores";

            using (SqlConnection connection = new SqlConnection(cnn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Agregar cada nombre de proveedor al ComboBox
                        string nombreProveedor = reader["Nomb_Proveedor"].ToString();
                        cbProveedores.Items.Add(nombreProveedor);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de errores, muestra un mensaje en caso de que ocurra una excepción
                    MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
                }
            }
        }

        public Gestionar_Compra()
        {
            InitializeComponent();
            LoadProveedorNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VolverAPantallaPrincipal pantallaPrincipal = new VolverAPantallaPrincipal();
            pantallaPrincipal.IrAPantallaPrincipal();
            this.Close();
        }

        private void Gestionar_Compra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet5.DetallePedidos' Puede moverla o quitarla según sea necesario.
            this.detallePedidosTableAdapter1.Fill(this.trabajoDeCampoDataSet5.DetallePedidos);
            CenterToScreen();
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet2.DetallePedidos' Puede moverla o quitarla según sea necesario.
          

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtPrecioProveedor.Text = "";
            txtCantidadProductoDeseado.Text = "";
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
                }
            }
        }

        public void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecioProveedor.Text = "";
            string Nombre = cbProveedores.Text;
            string ID = "";
           
            Controladora.ControlGestionarCompras gestionarCompras = new Controladora.ControlGestionarCompras();
            if(gestionarCompras.EncontrarIDProveedor(Nombre,out String IDProveedor) == false)
            {
                MessageBox.Show("Proveedor no esta en base de datos");
            }
            else
            {
                string Codigo = txtCodigoProduc.Text;
                ID = IDProveedor;
         

               if(gestionarCompras.BuscarProductoProveedor(Codigo,ID,out String PrecioProveedor) == false)
                {
                    MessageBox.Show("Proveedor : " + Nombre + " no tiene producto :" + txtNombreProduc.Text);
                }
                else
                {
                    txtPrecioProveedor.Text = PrecioProveedor;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoProduc.Text) ||
                string.IsNullOrEmpty(txtCantidadProductoDeseado.Text) ||
                string.IsNullOrEmpty(cbProveedores.Text)
                )
            {
                MessageBox.Show("Por favor, completa todos los datos.");
            }
            else
            {
                string Nombre = cbProveedores.Text;
                Controladora.ControlGestionarCompras AddDetalles=new Controladora.ControlGestionarCompras();
                if (AddDetalles.EncontrarIDProveedor(Nombre, out String IDProveedor) == false)
                {
                    MessageBox.Show("Proveedor no esta en base de datos");
                }
                else
                {
                    string Codigo = txtCodigoProduc.Text;
                    string ID = IDProveedor;
                    if (AddDetalles.AgregarDetallePedido(Codigo, ID, txtCantidadProductoDeseado.Text)==false)
                    {
                        MessageBox.Show("Ha ocurrio un error por favor reintentar en un ratito");
                    }
                    else
                    {
                        MessageBox.Show("Detalle Pedido agregado con exito ");
                        dgvDetallePedidos.Refresh();
                    }
                }
            }

        }
        private bool HayDatosRellenados()
        {
            foreach (DataGridViewRow row in dgvDetallePedidos.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Si la celda contiene algún valor, se considera que hay datos rellenados
                    if (cell.Value != null && cell.Value.ToString().Trim() != "")
                    {
                        return true;
                    }
                }
            }

            return false; // Si se llega aquí, no se encontraron datos rellenados en el DataGridView
        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            if (HayDatosRellenados() == false)
            {
                MessageBox.Show("aun no tiene ningun datos para generar pedidos");
            }
            else
            {
                DescargarPDF descargarPDF = new DescargarPDF();
                descargarPDF.Show();
                this.Hide();
            }
        }

        private void txtCodigoProduc_TextChanged(object sender, EventArgs e)
        {

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

        private void txtCantidadProductoDeseado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvDetallePedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
