namespace InteraçãoIOT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbIPValue = new System.Windows.Forms.TextBox();
            this.lblIIP = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPercentage = new System.Windows.Forms.Label();
            this.pbVelocidade = new System.Windows.Forms.ProgressBar();
            this.pbCLP = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCLP)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIPValue
            // 
            this.tbIPValue.Location = new System.Drawing.Point(297, 36);
            this.tbIPValue.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbIPValue.Name = "tbIPValue";
            this.tbIPValue.Size = new System.Drawing.Size(180, 29);
            this.tbIPValue.TabIndex = 0;
            // 
            // lblIIP
            // 
            this.lblIIP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblIIP.Location = new System.Drawing.Point(240, 36);
            this.lblIIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIIP.Name = "lblIIP";
            this.lblIIP.Size = new System.Drawing.Size(30, 29);
            this.lblIIP.TabIndex = 1;
            this.lblIIP.Text = "IP: ";
            this.lblIIP.Click += new System.EventHandler(this.lblIIP_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(515, 36);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(166, 29);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "CONECTAR COM O CLP";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(462, 270);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(96, 55);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "0%";
            // 
            // pbVelocidade
            // 
            this.pbVelocidade.Location = new System.Drawing.Point(84, 270);
            this.pbVelocidade.Name = "pbVelocidade";
            this.pbVelocidade.Size = new System.Drawing.Size(325, 55);
            this.pbVelocidade.TabIndex = 4;
            // 
            // pbCLP
            // 
            this.pbCLP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCLP.BackgroundImage")));
            this.pbCLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCLP.Location = new System.Drawing.Point(12, 8);
            this.pbCLP.Name = "pbCLP";
            this.pbCLP.Size = new System.Drawing.Size(186, 94);
            this.pbCLP.TabIndex = 5;
            this.pbCLP.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(84, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 98);
            this.button1.TabIndex = 6;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(266, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 98);
            this.button2.TabIndex = 7;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.LightBlue;
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(437, 108);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(61, 56);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.LightBlue;
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(437, 185);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(61, 56);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.BackColor = System.Drawing.Color.Purple;
            this.btnResetar.ForeColor = System.Drawing.Color.White;
            this.btnResetar.Location = new System.Drawing.Point(525, 145);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(156, 56);
            this.btnResetar.TabIndex = 10;
            this.btnResetar.Text = "RESETAR";
            this.btnResetar.UseVisualStyleBackColor = false;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 381);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbCLP);
            this.Controls.Add(this.pbVelocidade);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblIIP);
            this.Controls.Add(this.tbIPValue);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCLP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIPValue;
        private System.Windows.Forms.Label lblIIP;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.ProgressBar pbVelocidade;
        private System.Windows.Forms.PictureBox pbCLP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnResetar;
    }
}

