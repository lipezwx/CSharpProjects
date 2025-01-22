using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduinoCommunication
{


    public partial class Form4 : Form
    {

        public bool isFinished = false;

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
            bool isFinished = true;
            if (isFinished == true)
            {
                Random random = new Random();
                int randomNumber = random.Next();
                MessageBox.Show("O código serial do produto é: #" + randomNumber);
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Arduino turned off.");
        }
    }
}
