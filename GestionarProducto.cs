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
    public partial class GestionarProducto : Form
    {
        public GestionarProducto()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VolverAPantallaPrincipal pantallaPrincipal = new VolverAPantallaPrincipal();
            pantallaPrincipal.IrAPantallaPrincipal();
            this.Close();
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
