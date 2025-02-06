using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WalmartRecreation
{
    public partial class Form2 : Form
    {

        formPayments payments;
        formAddProducts addproducts;
        formSettings settings;


        bool sidebarExpand = false;
        bool menuExpand = false;
        string connectionString = "Server=localhost;Database=walmart;User Id=root;Password=;";

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flpHome.Height += 10;
                if (flpHome.Height >= 185)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else 
            {
                flpHome.Height -= 10;
                if (flpHome.Height <= 65) 
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                flpSidebar.Width += 10;
                if (flpSidebar.Width >= 220)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
            }
            else
            {
                flpSidebar.Width -= 10;
                if (flpSidebar.Width <= 0)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (payments == null)
            {
                payments = new formPayments();
                /*payments += */
                payments.MdiParent = this;
                payments.Show();
            }
            else 
            {
                payments.Activate();
            }
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}