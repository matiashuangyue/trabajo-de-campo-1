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
        public Ingresar_Stock_de_Mercaderia()
        {
            InitializeComponent();
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
    }
}
