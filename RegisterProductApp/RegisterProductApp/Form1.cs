using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RegisterProductApp
{
    public partial class MainWindow : Form
    {

        private Point lastPoint;
        private static string apiUrl = "http://localhost:80/elementsRegister.php";

        public MainWindow()
        {
            InitializeComponent();
            DraggableForm();
        }

        public void DraggableForm()
        {
            this.Text = "Non-Sizable Draggable Form";
            this.FormBorderStyle = FormBorderStyle.None;  // Remove the title bar
            this.StartPosition = FormStartPosition.CenterScreen;

            // Handle mouse events to enable dragging
            this.pnSuperiorBar.MouseDown += (sender, e) => { if (e.Button == MouseButtons.Left) lastPoint = e.Location; };
            this.pnSuperiorBar.MouseMove += (sender, e) => { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; } };
        }

        public static async Task SendPostSync(string json)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {

                    var response = await httpClient.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)

                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"API's Result: {result}");
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string product = tbProduct.Text;
            decimal tension = Decimal.Parse(tbTension.Text);
            decimal current = Decimal.Parse(tbCurrent.Text);


            PhpConsult newConsult = new PhpConsult(product, tension, current);

            string json = JsonConvert.SerializeObject(newConsult);

            await SendPostSync(json);
        }
    }
}
