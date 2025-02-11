using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduinoCommunication
{

    public partial class Form4 : Form
    {

        public bool isSuceed = false;
        SerialPort serialPort = new SerialPort();

        public Form4()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            if (cbSerialPort.Text != null)
            {
                startSerialCommunication();
                lblStatusBar.BackColor = Color.Green;
                lblStatusBar.Text = "ARDUINO ON";
            }
            else 
            {
                MessageBox.Show("Please select an serial port !");
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Arduino turned off.");
            lblStatusBar.BackColor = Color.Red;
            lblStatusBar.Text = "ARDUINO OFF";
        }


        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting().Trim();

            try
            {
                if (data == "R")
                {
                    string random = GenerateRandom();
                    MessageBox.Show("The product code is " + random);
                    addToSQL(random);

                    
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        void startSerialCommunication()
        {
            string[] ports = SerialPort.GetPortNames();

            serialPort = new SerialPort("COM3");
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;

            serialPort.DataReceived += Port_DataReceived;
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string GenerateRandom()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 99999);
            return "SN" + randomNumber.ToString();
        }

        void addToSQL(string random)
        {
            string connectionString = "server=localhost;user=root;database=arduino;password=";

            DateTime now = DateTime.Now;
            string query = "INSERT INTO example_table (serial_number, date_time) VALUES (@serial_number, @date_time)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@serial_number", random);
                    cmd.Parameters.AddWithValue("@date_time", now);

                    int rowsAffected = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cbSerialPort.Items.AddRange(SerialPort.GetPortNames());
        }
    }
}
