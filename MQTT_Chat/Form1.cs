using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT_Chat
{
    public partial class Form1: Form
    {

        private MqttClient _mqttClient;
        private string nameOfChat = "chat_1";

        public Form1()
        {
            InitializeComponent();

            RoundCorners();

            _mqttClient = new MqttClient("5715716fd0124cd9971ba73cbc85e5aa.s1.eu.hivemq.cloud", 8883, true, MqttSslProtocols.TLSv1_2, null, null);

            ConnectToMQTT();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectToMQTT()
        {
            if (_mqttClient is null || _mqttClient.IsConnected) return;

            _mqttClient.Connect(nameOfChat, "hivemq.webclient.1740231983947", "C1KaI2eABfc3h0gJ<.>,");

            if (!_mqttClient.IsConnected)
                throw new Exception("Can't connect to the broker.");

            _mqttClient.MqttMsgPublishReceived += ReceivedMessages;

            _mqttClient.Subscribe(new string[] {$"chat/{nameOfChat}"}, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
        }

        private void ReceivedMessages(object sender, MqttMsgPublishEventArgs e)
        {
            var topic = e.Topic;
            var message = Encoding.UTF8.GetString(e.Message);

            if (string.IsNullOrEmpty(topic) || string.IsNullOrEmpty(message)) return;

            lbMessageDisplay.Invoke(new Action(() => { lbMessageDisplay.Items.Add($"**{message}\r\n"); }));
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            var message = tbUserMessage.Text;

            if (string.IsNullOrEmpty(message)) return;

            if (!_mqttClient.IsConnected) 
            {
                ConnectToMQTT();
            }

            try
            {
                lbMessageDisplay.Invoke(new Action(() => { lbMessageDisplay.Items.Add($"**{message}\r\n"); }));
                tbUserMessage.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void RoundCorners()
        {
            // Set the radius for rounding corners
            int cornerRadius = 30;

            // Create a new rectangle that matches the form size
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);

            // Create an ellipse path that will match the corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90); // Top-left
            path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90); // Top-right
            path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right
            path.AddArc(bounds.X, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left

            // Close the path to make a full rectangle
            path.CloseAllFigures();

            // Apply the region to the form
            this.Region = new Region(path);
        }

        
    }
}
