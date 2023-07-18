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
    public partial class InfoTablas : Form
    {
        public InfoTablas()
        {
            InitializeComponent();
        }

        private void Tablas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet10.DetallePedidos' Puede moverla o quitarla según sea necesario.
            this.detallePedidosTableAdapter.Fill(this.trabajoDeCampoDataSet10.DetallePedidos);
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet8.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.trabajoDeCampoDataSet8.Productos);
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet7.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.trabajoDeCampoDataSet7.Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeCampoDataSet6.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.trabajoDeCampoDataSet6.Usuarios);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VolverAPantallaPrincipal pantallaPrincipal = new VolverAPantallaPrincipal();
            pantallaPrincipal.IrAPantallaPrincipal();
            this.Close();
        }
    }
}
