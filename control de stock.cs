﻿using System;
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
        public control_de_stock()
        {
            InitializeComponent();
        }

        public void IngresarNuevaStock()
        {
            Ingresar_Stock_de_Mercaderia IngresarNuevaStock = new Ingresar_Stock_de_Mercaderia();
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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VolverAPantallaPrincipal pantallaPrincipal = new VolverAPantallaPrincipal();
            pantallaPrincipal.IrAPantallaPrincipal();
            this.Close();
        }

        private void btnIngresarStock_Click(object sender, EventArgs e)
        {
            IngresarNuevaStock();
        }
    }
}
