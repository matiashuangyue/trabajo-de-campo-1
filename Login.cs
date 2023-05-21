using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace trabajo_de_campo_1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using(SqlConnection conn = new SqlConnection(cnn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT id , contraseña FROM Usuarios where id ='"+txtUser.Text+"'AND contraseña='"+txtPassword.Text+"'", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            cambiarformulario();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos");
                            conn.Close();
                        }
                    }
                }
            }
            catch(Exception ex ) 
            {
                MessageBox.Show(ex.ToString());
            }    
        }
        
            public void cambiarformulario()
        {
            PantallaPrincipal pantalla1 = new PantallaPrincipal();
            pantalla1.Show();
            this.Hide();
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            logins();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
