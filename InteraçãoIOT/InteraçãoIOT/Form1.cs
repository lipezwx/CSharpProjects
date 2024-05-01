using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace InteraçãoIOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ModbusClient CLP = new ModbusClient();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                CLP.UnitIdentifier = 255;
                CLP.Connect(tbIPValue.Text, 502);
                MessageBox.Show("O CLP FOI CONECTADO COM SUCESSO.");

                timer1.Enabled = true;

            }
            catch
            {
                MessageBox.Show("HOUVE UMA FALHA NA CONEXÃO DO CLP.");
            }
        }

        int[] HOLDING;


        private void lblIIP_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                HOLDING = CLP.ReadHoldingRegisters(100, 1);

                lblPercentage.Text = (HOLDING[0]).ToString() + "%";
                pbVelocidade.Value = (HOLDING[0]);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLP.WriteSingleCoil(0, true);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLP.WriteSingleCoil(0, false);

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            CLP.WriteSingleCoil(12, true);
            CLP.WriteSingleCoil(12, false);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            CLP.WriteSingleCoil(11, true);
            CLP.WriteSingleCoil(11, false);
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            CLP.WriteSingleCoil(13, true);
            CLP.WriteSingleCoil(13, false);
        }
    }
}
