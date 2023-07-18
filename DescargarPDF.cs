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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace trabajo_de_campo_1
{
    public partial class DescargarPDF : Form
    {
        private DataTable dtDatos;
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

 
        private void rellenarDatosGridview()
        {
            string Nombre = cbProveedores.Text;
            
            Controladora.ControlGestionarCompras gestionarCompras = new Controladora.ControlGestionarCompras();
            Controladora.ControlDescargarPDF DescargarPDF= new Controladora.ControlDescargarPDF();
            if (gestionarCompras.EncontrarIDProveedor(Nombre, out String IDProveedor) == false)
            {
                MessageBox.Show("Proveedor no esta en base de datos");
            }
            else
            {
                List<DetallePedido> detallesProveedor = BuscarDetalles(IDProveedor);    
                dgvPediddosProveedor.DataSource = detallesProveedor;
            }

        }
        public DescargarPDF()
        {
            InitializeComponent();
            LoadProveedorNames();
        }

        private void DescargarPDF_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPediddosProveedor.DataSource = null;
            rellenarDatosGridview();
        }






        private void btnBack_Click(object sender, EventArgs e)
        {

            Gestionar_Compra gestionarCompra = new Gestionar_Compra();
            gestionarCompra.Show();
            this.Hide();

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            descargarFactura();
        }


        public void descargarFactura()
        {

            int TOTAL = 0; 
         using (SqlConnection conn= new SqlConnection(cnn))
         {
           
                if (cbProveedores.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un Proveedor");

                }
             else
             { 
                if(dgvPediddosProveedor.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay Pedidos disponible para descargar");
                    }
                    else
                    {
                        try
                        {
                            
                            conn.Open();
                            dgvPediddosProveedor.Refresh();
                            SaveFileDialog GenerarFactura = new SaveFileDialog();
                            GenerarFactura.FileName = "Factura StarOG " + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";
                            string paginahtml_texto = Properties.Resources.plantilla.ToString();
                            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                            paginahtml_texto = paginahtml_texto.Replace("@Proveedor", cbProveedores.Text);
                            string filas = string.Empty;
                            try //Intentará recorrer todas las filas 
                            {
                                for (int fila = 0; fila < dgvPediddosProveedor.Rows.Count - 1; fila++) //Recorrer todas las filas de datogridview
                                {
                                    filas += "<tr>"; //Arrancar una fila

                                    for (int col = 0; col < dgvPediddosProveedor.Rows[fila].Cells.Count; col++) //Recorrer todos los columnas de la fila definido
                                    {
                                        string valor = dgvPediddosProveedor.Rows[fila].Cells[col].Value.ToString(); //Transformar datos a string para puede guardar
                                        filas += "<td>" + valor + "</td>"; //Guardar todos los valores de fila en variable" fila "
                                        if (col == 2)
                                        {
                                            int precio = int.Parse(valor); // Convertir el valor a entero (o decimal, según corresponda)
                                            TOTAL += precio; // Sumar el precio al total
                                        }
                                    }
                                    filas += "</tr>";//Cerrar la fila 
                                }
                                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas); //Pasar datos que se almacena fila a la tabla de HTML
                                paginahtml_texto = paginahtml_texto.Replace("@TOTAL", TOTAL.ToString());
                                //Aca se crea el pdf y se cargan algunos datos más, como la imagen que nosotros queremos para la factura
                                if (GenerarFactura.ShowDialog() == DialogResult.OK)
                                {
                                    using (FileStream stream = new FileStream(GenerarFactura.FileName, FileMode.Create))
                                    {
                                        Document pdfDOC = new Document(PageSize.A4, 25, 25, 25, 25); //Dar tamaño y detalle de pdf

                                        PdfWriter writer = PdfWriter.GetInstance(pdfDOC, stream); //Dar escritura en documentos que definimos 

                                        pdfDOC.Open();
                                        pdfDOC.Add(new Phrase(""));
                                        //Dar icono para pdf
                                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.panda, System.Drawing.Imaging.ImageFormat.Png);
                                        img.ScaleToFit(80, 60);
                                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                                        img.SetAbsolutePosition(pdfDOC.LeftMargin, pdfDOC.Top - 60);
                                        pdfDOC.Add(img);
                                        //Transformar la pagina de html con los datos  a pdf 
                                        using (StringReader sr = new StringReader(paginahtml_texto))
                                        {
                                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDOC, sr);
                                        }

                                        pdfDOC.Close();
                                        stream.Close();
                                    }
                                }
                            }
                            catch (Exception) //En caso de que no se haya podido crear el PDF, se mostrará un mensaje de error
                            {
                                MessageBox.Show("No se pudo descargar el PDF. Por favor, vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Manejo de errores, muestra un mensaje en caso de que ocurra una excepción
                            MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
                        }
                    }

             }

         }
         
        }

        public List<DetallePedido> BuscarDetalles(string ID_Proveedor)
        {
            List<DetallePedido> detalles = new List<DetallePedido>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Cod_Producto, Cantidad, Precio FROM DetallePedidos WHERE ID_Proveedor  ='" + ID_Proveedor + "'", conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            string codProducto = dr["Cod_Producto"].ToString();
                            string Cantidad = dr["Cantidad"].ToString();
                            string precio = dr["Precio"].ToString();

                            detalles.Add(new DetallePedido
                            {
                                CodigoDeProducto = codProducto,
                                CantidadDeseado = Cantidad,
                                PrecioPorCantidad = precio
                            });
                        }

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones aquí
            }

            return detalles;
        }




    }
    public class DetallePedido
    {
        public string CodigoDeProducto { get; set; }
        public string CantidadDeseado { get; set; }
        public string PrecioPorCantidad { get; set; }
    }
}
