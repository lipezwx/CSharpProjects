using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using Google.Protobuf.WellKnownTypes;
using System.Xml;
using System.Configuration;

namespace arduinoCommunication
{
    public partial class Form2 : Form
    {

        string connectionString = "server=localhost;user=root;database=arduino;password=";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void cbbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Adding items to the combo box
            cbbFuncao.Items.Add("Operador");
            cbbFuncao.Items.Add("Lider");
            cbbFuncao.Items.Add("Técnico");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string query = "INSERT INTO tela_cadastro (username, password, function, name, last_name, date_time) VALUES (@username, @password, @function, @name, @last_name, @date_time)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (tbUsuario.Text != string.Empty && tbSenha.Text != string.Empty && cbbFuncao.Text != string.Empty && tbNome.Text != string.Empty && tbSobrenome.Text != string.Empty)
                {
                    try
                    {
                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", tbUsuario.Text);
                        cmd.Parameters.AddWithValue("@password", tbSenha.Text);
                        cmd.Parameters.AddWithValue("@function", cbbFuncao.Text);
                        cmd.Parameters.AddWithValue("@name", tbNome.Text);
                        cmd.Parameters.AddWithValue("@last_name", tbSobrenome.Text);
                        cmd.Parameters.AddWithValue("@date_time", now);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show("Sucessfully Signed in !");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else 
                {
                    MessageBox.Show("There's a empty field ! Please fix it !");
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
