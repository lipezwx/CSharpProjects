namespace MQTT_Chat
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbMessageDisplay = new System.Windows.Forms.ListBox();
            this.tbUserMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.pnTopbar = new System.Windows.Forms.Panel();
            this.pbMqttLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnTopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMqttLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessageDisplay
            // 
            this.lbMessageDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(235)))));
            this.lbMessageDisplay.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessageDisplay.FormattingEnabled = true;
            this.lbMessageDisplay.ItemHeight = 58;
            this.lbMessageDisplay.Location = new System.Drawing.Point(40, 117);
            this.lbMessageDisplay.Name = "lbMessageDisplay";
            this.lbMessageDisplay.Size = new System.Drawing.Size(1192, 236);
            this.lbMessageDisplay.TabIndex = 0;
            // 
            // tbUserMessage
            // 
            this.tbUserMessage.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserMessage.Location = new System.Drawing.Point(40, 394);
            this.tbUserMessage.Multiline = true;
            this.tbUserMessage.Name = "tbUserMessage";
            this.tbUserMessage.Size = new System.Drawing.Size(1192, 129);
            this.tbUserMessage.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(40, 549);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(1192, 137);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // pnTopbar
            // 
            this.pnTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(38)))), ((int)(((byte)(187)))));
            this.pnTopbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnTopbar.Controls.Add(this.pbMqttLogo);
            this.pnTopbar.Controls.Add(this.btnMinimize);
            this.pnTopbar.Controls.Add(this.btnExit);
            this.pnTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTopbar.Location = new System.Drawing.Point(0, 0);
            this.pnTopbar.Name = "pnTopbar";
            this.pnTopbar.Size = new System.Drawing.Size(1280, 101);
            this.pnTopbar.TabIndex = 3;
            // 
            // pbMqttLogo
            // 
            this.pbMqttLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbMqttLogo.Image")));
            this.pbMqttLogo.Location = new System.Drawing.Point(517, 0);
            this.pbMqttLogo.Name = "pbMqttLogo";
            this.pbMqttLogo.Size = new System.Drawing.Size(313, 101);
            this.pbMqttLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMqttLogo.TabIndex = 2;
            this.pbMqttLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1170, 23);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 48);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1222, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbUserMessage);
            this.Controls.Add(this.lbMessageDisplay);
            this.Controls.Add(this.pnTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnTopbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMqttLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUserMessage;
        private System.Windows.Forms.Button btnSendMessage;
        public System.Windows.Forms.ListBox lbMessageDisplay;
        private System.Windows.Forms.Panel pnTopbar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pbMqttLogo;
    }
}

