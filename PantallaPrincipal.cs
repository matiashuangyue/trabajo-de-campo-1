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
            GestionarProducto GestionarProducto = new GestionarProducto();
            GestionarProducto.Show();
            this.Hide();
        }
        public void GestionarProvedor()
        {
            GestionarProvedor GestionarProvedor = new GestionarProvedor();
            GestionarProvedor.Show();
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
    }
}
