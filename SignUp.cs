using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;



namespace trabajo_de_campo_1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /*
        public static bool IsValidID(string DNI) 
        {
            if (string.IsNullOrWhiteSpace(DNI))
                return false;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ID_Usuario FROM Usuarios where ID_Usuario ='" + DNI + "'", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            
                            conn.Close();
                            return false;
                        }
                        else
                        {
                            conn.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void Validaciones()
        {
            bool validar = true;
             if (IsValidID(txtID.Text) == false)
            {
                MessageBox.Show("Ya existe este ID en base de datos o no esta completado");
                validar = false;
            }   
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Revisar campo del Nombre");
                validar = false;
            }
            if (string.IsNullOrWhiteSpace(txtPassWord.Text))
            {
                MessageBox.Show("Revisar campo del contraseña");
                validar = false;
            }
            if (IsValidEmail(txtMail.Text) == false)
            {
                MessageBox.Show("Revisar campo de mail");
                validar = false;
            }
           
            if (validar==true)
            {
                String QueryDatosValidos = "insert into Usuarios ([ID_Usuario],[Nomb_Usuario],[Contraseña_Usuario],[Mail_Usuario])"
                    + "values ('"+txtID.Text+"','"+txtName.Text+"','"+txtPassWord.Text+"','"+txtMail.Text+"')";
                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(cnn))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(QueryDatosValidos , conn))
                        {
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    } 
                    MessageBox.Show(txtName.Text + "se registro con existo");
                    VolverALogin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
      
        }
        */
        public void VolverALogin()
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           Controladora.ControlSignUp signUp = new Controladora.ControlSignUp();
            if(signUp.RegistrarCuenta(txtID.Text, txtName.Text, txtPassWord.Text, txtMail.Text) == false)
            {
                MessageBox.Show("chequea sus datos porfavor");
            }
           // Validaciones();

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            VolverALogin();
        }
    }
}
