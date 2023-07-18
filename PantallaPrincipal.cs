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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        public void GestionarProducto()
        {
            GestionarProductos GestionarProducto = new GestionarProductos();
            GestionarProducto.Show();
            this.Hide();
        }
        public void GestionarProvedor()
        {
            GestionarProveedores GestionarProvedor = new GestionarProveedores();
            GestionarProvedor.Show();
            this.Hide();
        }
        public void GestionarCompra()
        {
            Gestionar_Compra GestionarCompra = new Gestionar_Compra();
            GestionarCompra.Show();
            this.Hide();
        }

        public void ControlDeStock()
        {
            control_de_stock ControlDeStock = new control_de_stock();
            ControlDeStock.Show();
            this.Hide();
        }

        private void btnGestionarProducto_Click(object sender, EventArgs e)
        {
            GestionarProducto();
        }

        private void btnGestionarProvedor_Click(object sender, EventArgs e)
        {
            GestionarProvedor();
        }
        private void btnControlStock_Click(object sender, EventArgs e)
         {
            ControlDeStock();
         }       

        private void btnGestionarCompra_Click(object sender, EventArgs e)
         {
             GestionarCompra();
         }
        public void VolverAPaginaAnterior()
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            VolverAPaginaAnterior();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnSolicitarInforme_Click(object sender, EventArgs e)
        {
            InfoTablas infoTablas = new InfoTablas();
            infoTablas.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
