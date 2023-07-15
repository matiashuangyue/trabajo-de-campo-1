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
using Controladora;

namespace trabajo_de_campo_1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        

        public void cambiarformulario()
        {
            PantallaPrincipal pantalla1 = new PantallaPrincipal();
            pantalla1.Show();
            this.Hide();
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser != null)
            {
                if (txtPassword != null)
                {
                    ControlLogin  User= new ControlLogin();
                    var LoginValido = User.InicialSesion(txtUser.Text, txtPassword.Text);
                    if (LoginValido)
                    {
                        cambiarformulario();
                    }
                    else
                    {
                        MessageBox.Show("El Usuario o Contrasena es invalido");
                    }
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
