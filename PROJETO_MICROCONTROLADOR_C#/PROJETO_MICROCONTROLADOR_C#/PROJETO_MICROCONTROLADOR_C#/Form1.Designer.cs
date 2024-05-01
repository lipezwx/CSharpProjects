namespace PROJETO_MICROCONTROLADOR_C_
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
            this.pnLogoSenai = new System.Windows.Forms.Panel();
            this.lblCabeçalho = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPORTACOM = new System.Windows.Forms.ComboBox();
            this.lblPORTACOM = new System.Windows.Forms.Label();
            this.btnConectar_Desconectar = new System.Windows.Forms.Button();
            this.lblEstadoCnx = new System.Windows.Forms.Label();
            this.btnON = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVENT = new System.Windows.Forms.Label();
            this.pnLogoSenai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogoSenai
            // 
            this.pnLogoSenai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogoSenai.Controls.Add(this.lblCabeçalho);
            this.pnLogoSenai.Controls.Add(this.pictureBox1);
            this.pnLogoSenai.Location = new System.Drawing.Point(1, 1);
            this.pnLogoSenai.Name = "pnLogoSenai";
            this.pnLogoSenai.Size = new System.Drawing.Size(764, 98);
            this.pnLogoSenai.TabIndex = 0;
            this.pnLogoSenai.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCabeçalho
            // 
            this.lblCabeçalho.AutoSize = true;
            this.lblCabeçalho.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabeçalho.Location = new System.Drawing.Point(311, 34);
            this.lblCabeçalho.Name = "lblCabeçalho";
            this.lblCabeçalho.Size = new System.Drawing.Size(317, 33);
            this.lblCabeçalho.TabIndex = 2;
            this.lblCabeçalho.Text = "Projeto Micro-Controlador";
            this.lblCabeçalho.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // cbPORTACOM
            // 
            this.cbPORTACOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPORTACOM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPORTACOM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPORTACOM.FormattingEnabled = true;
            this.cbPORTACOM.Location = new System.Drawing.Point(159, 132);
            this.cbPORTACOM.Name = "cbPORTACOM";
            this.cbPORTACOM.Size = new System.Drawing.Size(195, 27);
            this.cbPORTACOM.TabIndex = 1;
            this.cbPORTACOM.SelectedIndexChanged += new System.EventHandler(this.cbPORTACOM_SelectedIndexChanged_1);
            // 
            // lblPORTACOM
            // 
            this.lblPORTACOM.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPORTACOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPORTACOM.Location = new System.Drawing.Point(33, 132);
            this.lblPORTACOM.Name = "lblPORTACOM";
            this.lblPORTACOM.Size = new System.Drawing.Size(129, 27);
            this.lblPORTACOM.TabIndex = 2;
            this.lblPORTACOM.Text = "PORTACOM: ";
            this.lblPORTACOM.Click += new System.EventHandler(this.lblPORTACOM_Click);
            // 
            // btnConectar_Desconectar
            // 
            this.btnConectar_Desconectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConectar_Desconectar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar_Desconectar.Location = new System.Drawing.Point(360, 132);
            this.btnConectar_Desconectar.Name = "btnConectar_Desconectar";
            this.btnConectar_Desconectar.Size = new System.Drawing.Size(159, 27);
            this.btnConectar_Desconectar.TabIndex = 3;
            this.btnConectar_Desconectar.Text = "Conectar";
            this.btnConectar_Desconectar.UseVisualStyleBackColor = true;
            this.btnConectar_Desconectar.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // lblEstadoCnx
            // 
            this.lblEstadoCnx.BackColor = System.Drawing.Color.Red;
            this.lblEstadoCnx.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCnx.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstadoCnx.Location = new System.Drawing.Point(537, 132);
            this.lblEstadoCnx.Name = "lblEstadoCnx";
            this.lblEstadoCnx.Size = new System.Drawing.Size(215, 27);
            this.lblEstadoCnx.TabIndex = 4;
            this.lblEstadoCnx.Text = "DESCONECTADO";
            this.lblEstadoCnx.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // btnON
            // 
            this.btnON.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnON.ForeColor = System.Drawing.Color.Green;
            this.btnON.Location = new System.Drawing.Point(37, 234);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(137, 100);
            this.btnON.TabIndex = 5;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOFF.ForeColor = System.Drawing.Color.Red;
            this.btnOFF.Location = new System.Drawing.Point(192, 234);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(137, 100);
            this.btnOFF.TabIndex = 6;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(409, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 100);
            this.button1.TabIndex = 7;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(565, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 100);
            this.button2.TabIndex = 8;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "LED";
            // 
            // lblVENT
            // 
            this.lblVENT.AutoSize = true;
            this.lblVENT.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVENT.Location = new System.Drawing.Point(453, 191);
            this.lblVENT.Name = "lblVENT";
            this.lblVENT.Size = new System.Drawing.Size(218, 40);
            this.lblVENT.TabIndex = 11;
            this.lblVENT.Text = "VENTOINHA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(764, 384);
            this.Controls.Add(this.lblVENT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.lblEstadoCnx);
            this.Controls.Add(this.btnConectar_Desconectar);
            this.Controls.Add(this.lblPORTACOM);
            this.Controls.Add(this.cbPORTACOM);
            this.Controls.Add(this.pnLogoSenai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLogoSenai.ResumeLayout(false);
            this.pnLogoSenai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLogoSenai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCabeçalho;
        private System.Windows.Forms.ComboBox cbPORTACOM;
        private System.Windows.Forms.Label lblPORTACOM;
        private System.Windows.Forms.Button btnConectar_Desconectar;
        private System.Windows.Forms.Label lblEstadoCnx;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVENT;
    }
}

