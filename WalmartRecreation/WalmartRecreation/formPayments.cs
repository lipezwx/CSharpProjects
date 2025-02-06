using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalmartRecreation
{
    public partial class formPayments : Form
    {
        public formPayments()
        {
            InitializeComponent();
        }

        private void formPayments_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void payments_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
