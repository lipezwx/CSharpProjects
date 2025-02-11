namespace arduinoCommunication
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArduino = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArduino
            // 
            this.lblArduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblArduino.Font = new System.Drawing.Font("Adobe Pi Std", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArduino.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArduino.Location = new System.Drawing.Point(0, 0);
            this.lblArduino.Name = "lblArduino";
            this.lblArduino.Size = new System.Drawing.Size(801, 72);
            this.lblArduino.TabIndex = 0;
            this.lblArduino.Text = "Arduino";
            this.lblArduino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Adobe Pi Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(758, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Adobe Pi Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Location = new System.Drawing.Point(722, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 34);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "--";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnON
            // 
            this.btnON.Font = new System.Drawing.Font("Adobe Pi Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnON.ForeColor = System.Drawing.Color.Green;
            this.btnON.Location = new System.Drawing.Point(160, 178);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(128, 128);
            this.btnON.TabIndex = 3;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Font = new System.Drawing.Font("Adobe Pi Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOFF.Location = new System.Drawing.Point(458, 178);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(128, 128);
            this.btnOFF.TabIndex = 4;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialPort.Font = new System.Drawing.Font("Adobe Myungjo Std M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(317, 221);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(121, 24);
            this.cbSerialPort.TabIndex = 5;
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.BackColor = System.Drawing.Color.Red;
            this.lblStatusBar.Font = new System.Drawing.Font("Adobe Myungjo Std M", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatusBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatusBar.Location = new System.Drawing.Point(-1, 368);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(802, 83);
            this.lblStatusBar.TabIndex = 6;
            this.lblStatusBar.Text = "ARDUINO OFF";
            this.lblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatusBar);
            this.Controls.Add(this.cbSerialPort);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblArduino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblArduino;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Label lblStatusBar;
    }
}