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
    public partial class Gestionar_Compra : Form
    {
        public Gestionar_Compra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VolverAPantallaPrincipal pantallaPrincipal = new VolverAPantallaPrincipal();
            pantallaPrincipal.IrAPantallaPrincipal();
            this.Close();
        }

        private void Gestionar_Compra_Load(object sender, EventArgs e)
        {

        }
    }
}
