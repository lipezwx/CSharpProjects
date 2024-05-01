using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace PROJETO_MICROCONTROLADOR_C_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void cbPORTACOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        #region Declaração de variáveis globais

        bool flag_conexao_COM = false; // 0 -> Desconectado; 1 -> Conectado
        

        #endregion


    SerialPort PLACA_SERIAL = new SerialPort();

    private void Form1_Load(object sender, EventArgs e)
        {
            string[] LISTA_COM;
            LISTA_COM = SerialPort.GetPortNames();

            for (int i = 0; i < LISTA_COM.Length; i++)
            {
                cbPORTACOM.Items.Add(LISTA_COM[i]);
            }

            cbPORTACOM.Items.Add("Selecione: ");
            cbPORTACOM.SelectedIndex = 0;
           
            
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void cbPORTACOM_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            bool flag_aux_conexao = false;
            if (flag_conexao_COM == false) 
            {
                #region Rotinas de conexão com terminal serial
                if (cbPORTACOM.Text != "Selecione: ")
                {
                    try
                    {
                        PLACA_SERIAL.PortName = cbPORTACOM.Text;
                        PLACA_SERIAL.BaudRate = 9600;
                        PLACA_SERIAL.Parity = Parity.None;
                        PLACA_SERIAL.DataBits = 8;
                        PLACA_SERIAL.StopBits = StopBits.One;


                        PLACA_SERIAL.Open();

                        lblEstadoCnx.Text = "CONECTADO";
                        lblEstadoCnx.BackColor = Color.Green;
                        btnConectar_Desconectar.Text = "Desconectar";
                        flag_conexao_COM = true;
                        flag_aux_conexao = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("ERRO!, Nenhuma porta COM foi selecionada!", "Senai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion

            }
            if (flag_conexao_COM == true && flag_aux_conexao == false)
            {
                #region Rotina para desconectar o terminal serial

                try
                {
                    PLACA_SERIAL.Close();
                    lblEstadoCnx.Text = "DESCONECTADO";
                    lblEstadoCnx.BackColor = Color.Red;
                    flag_conexao_COM = false;
                    btnConectar_Desconectar.Text = "Conectar";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion
            }
        

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            try
            {
                PLACA_SERIAL.Write("[10]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void lblPORTACOM_Click(object sender, EventArgs e)
        {

        }

        private void btnON_Click(object sender, EventArgs e)
        {
            try
            {
                PLACA_SERIAL.Write("[11]");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PLACA_SERIAL.Write("[21]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                PLACA_SERIAL.Write("[20]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}