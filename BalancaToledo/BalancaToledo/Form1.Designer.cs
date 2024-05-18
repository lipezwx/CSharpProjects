namespace BalancaToledo
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
            this.btnTaraIncrease = new System.Windows.Forms.Button();
            this.btnTaraDecrease = new System.Windows.Forms.Button();
            this.lblTara = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPesoMaximoValue = new System.Windows.Forms.Label();
            this.lblPesoMinimoValue = new System.Windows.Forms.Label();
            this.lblTaraValue = new System.Windows.Forms.Label();
            this.btnPesoMaximoDecrease = new System.Windows.Forms.Button();
            this.btnPesoMaximoIncrease = new System.Windows.Forms.Button();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.btnPesoMinimoDecrease = new System.Windows.Forms.Button();
            this.btnPesoMinimoIncrease = new System.Windows.Forms.Button();
            this.lblPesoMinimo = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblPesoProduto = new System.Windows.Forms.Label();
            this.btnPesoProdutoIncrease = new System.Windows.Forms.Button();
            this.btnPesoProdutoDecrease = new System.Windows.Forms.Button();
            this.lblPesoProdutoValue = new System.Windows.Forms.Label();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.pbLogoPrix = new System.Windows.Forms.PictureBox();
            this.lblBalancaToledo = new System.Windows.Forms.Label();
            this.mpBalancaToledo = new MetroFramework.Controls.MetroPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrix)).BeginInit();
            this.mpBalancaToledo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaraIncrease
            // 
            this.btnTaraIncrease.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTaraIncrease.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaraIncrease.Location = new System.Drawing.Point(0, 50);
            this.btnTaraIncrease.Name = "btnTaraIncrease";
            this.btnTaraIncrease.Size = new System.Drawing.Size(62, 47);
            this.btnTaraIncrease.TabIndex = 0;
            this.btnTaraIncrease.Text = "Aumentar";
            this.btnTaraIncrease.UseVisualStyleBackColor = true;
            this.btnTaraIncrease.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTaraDecrease
            // 
            this.btnTaraDecrease.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTaraDecrease.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaraDecrease.Location = new System.Drawing.Point(68, 50);
            this.btnTaraDecrease.Name = "btnTaraDecrease";
            this.btnTaraDecrease.Size = new System.Drawing.Size(62, 47);
            this.btnTaraDecrease.TabIndex = 1;
            this.btnTaraDecrease.Text = "Diminuir";
            this.btnTaraDecrease.UseVisualStyleBackColor = true;
            this.btnTaraDecrease.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTara.Location = new System.Drawing.Point(39, 26);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(43, 21);
            this.lblTara.TabIndex = 2;
            this.lblTara.Text = "Tara";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAvaliar);
            this.panel1.Controls.Add(this.lblPesoProdutoValue);
            this.panel1.Controls.Add(this.btnPesoProdutoDecrease);
            this.panel1.Controls.Add(this.btnPesoProdutoIncrease);
            this.panel1.Controls.Add(this.lblPesoProduto);
            this.panel1.Controls.Add(this.btnValidar);
            this.panel1.Controls.Add(this.lblPesoMaximoValue);
            this.panel1.Controls.Add(this.lblPesoMinimoValue);
            this.panel1.Controls.Add(this.lblTaraValue);
            this.panel1.Controls.Add(this.btnPesoMaximoDecrease);
            this.panel1.Controls.Add(this.btnPesoMaximoIncrease);
            this.panel1.Controls.Add(this.lblPesoMaximo);
            this.panel1.Controls.Add(this.btnPesoMinimoDecrease);
            this.panel1.Controls.Add(this.btnPesoMinimoIncrease);
            this.panel1.Controls.Add(this.lblPesoMinimo);
            this.panel1.Controls.Add(this.lblTara);
            this.panel1.Controls.Add(this.btnTaraDecrease);
            this.panel1.Controls.Add(this.btnTaraIncrease);
            this.panel1.Location = new System.Drawing.Point(1, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 170);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblPesoMaximoValue
            // 
            this.lblPesoMaximoValue.AutoSize = true;
            this.lblPesoMaximoValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPesoMaximoValue.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoMaximoValue.Location = new System.Drawing.Point(391, 120);
            this.lblPesoMaximoValue.Name = "lblPesoMaximoValue";
            this.lblPesoMaximoValue.Size = new System.Drawing.Size(30, 33);
            this.lblPesoMaximoValue.TabIndex = 10;
            this.lblPesoMaximoValue.Text = "0";
            this.lblPesoMaximoValue.Click += new System.EventHandler(this.lblPesoMaximoValue_Click);
            // 
            // lblPesoMinimoValue
            // 
            this.lblPesoMinimoValue.AutoSize = true;
            this.lblPesoMinimoValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPesoMinimoValue.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoMinimoValue.Location = new System.Drawing.Point(220, 120);
            this.lblPesoMinimoValue.Name = "lblPesoMinimoValue";
            this.lblPesoMinimoValue.Size = new System.Drawing.Size(30, 33);
            this.lblPesoMinimoValue.TabIndex = 9;
            this.lblPesoMinimoValue.Text = "0";
            // 
            // lblTaraValue
            // 
            this.lblTaraValue.AutoSize = true;
            this.lblTaraValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaraValue.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaraValue.Location = new System.Drawing.Point(54, 120);
            this.lblTaraValue.Name = "lblTaraValue";
            this.lblTaraValue.Size = new System.Drawing.Size(30, 33);
            this.lblTaraValue.TabIndex = 4;
            this.lblTaraValue.Text = "0";
            this.lblTaraValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPesoMaximoDecrease
            // 
            this.btnPesoMaximoDecrease.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesoMaximoDecrease.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesoMaximoDecrease.Location = new System.Drawing.Point(417, 50);
            this.btnPesoMaximoDecrease.Name = "btnPesoMaximoDecrease";
            this.btnPesoMaximoDecrease.Size = new System.Drawing.Size(62, 47);
            this.btnPesoMaximoDecrease.TabIndex = 8;
            this.btnPesoMaximoDecrease.Text = "Diminuir";
            this.btnPesoMaximoDecrease.UseVisualStyleBackColor = true;
            this.btnPesoMaximoDecrease.Click += new System.EventHandler(this.btnPesoMaximoDecrease_Click);
            // 
            // btnPesoMaximoIncrease
            // 
            this.btnPesoMaximoIncrease.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesoMaximoIncrease.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesoMaximoIncrease.Location = new System.Drawing.Point(336, 50);
            this.btnPesoMaximoIncrease.Name = "btnPesoMaximoIncrease";
            this.btnPesoMaximoIncrease.Size = new System.Drawing.Size(62, 47);
            this.btnPesoMaximoIncrease.TabIndex = 7;
            this.btnPesoMaximoIncrease.Text = "Aumentar";
            this.btnPesoMaximoIncrease.UseVisualStyleBackColor = true;
            this.btnPesoMaximoIncrease.Click += new System.EventHandler(this.btnPesoMaximoIncrease_Click);
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoMaximo.Location = new System.Drawing.Point(355, 26);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(113, 21);
            this.lblPesoMaximo.TabIndex = 6;
            this.lblPesoMaximo.Text = "Peso Máximo";
            this.lblPesoMaximo.Click += new System.EventHandler(this.lblPesoMaximo_Click);
            // 
            // btnPesoMinimoDecrease
            // 
            this.btnPesoMinimoDecrease.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesoMinimoDecrease.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesoMinimoDecrease.Location = new System.Drawing.Point(242, 50);
            this.btnPesoMinimoDecrease.Name = "btnPesoMinimoDecrease";
            this.btnPesoMinimoDecrease.Size = new System.Drawing.Size(62, 47);
            this.btnPesoMinimoDecrease.TabIndex = 5;
            this.btnPesoMinimoDecrease.Text = "Diminuir";
            this.btnPesoMinimoDecrease.UseVisualStyleBackColor = true;
            this.btnPesoMinimoDecrease.Click += new System.EventHandler(this.btnPesoMinimoDecrease_Click);
            // 
            // btnPesoMinimoIncrease
            // 
            this.btnPesoMinimoIncrease.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesoMinimoIncrease.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesoMinimoIncrease.Location = new System.Drawing.Point(165, 50);
            this.btnPesoMinimoIncrease.Name = "btnPesoMinimoIncrease";
            this.btnPesoMinimoIncrease.Size = new System.Drawing.Size(62, 47);
            this.btnPesoMinimoIncrease.TabIndex = 4;
            this.btnPesoMinimoIncrease.Text = "Aumentar";
            this.btnPesoMinimoIncrease.UseVisualStyleBackColor = true;
            this.btnPesoMinimoIncrease.Click += new System.EventHandler(this.btnPesoMinimoIncrease_Click);
            // 
            // lblPesoMinimo
            // 
            this.lblPesoMinimo.AutoSize = true;
            this.lblPesoMinimo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoMinimo.Location = new System.Drawing.Point(180, 26);
            this.lblPesoMinimo.Name = "lblPesoMinimo";
            this.lblPesoMinimo.Size = new System.Drawing.Size(111, 21);
            this.lblPesoMinimo.TabIndex = 3;
            this.lblPesoMinimo.Text = "Peso Mínimo";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(494, 74);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblPesoProduto
            // 
            this.lblPesoProduto.AutoSize = true;
            this.lblPesoProduto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoProduto.Location = new System.Drawing.Point(610, 26);
            this.lblPesoProduto.Name = "lblPesoProduto";
            this.lblPesoProduto.Size = new System.Drawing.Size(138, 21);
            this.lblPesoProduto.TabIndex = 11;
            this.lblPesoProduto.Text = "Peso do Produto";
            this.lblPesoProduto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnPesoProdutoIncrease
            // 
            this.btnPesoProdutoIncrease.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesoProdutoIncrease.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesoProdutoIncrease.Location = new System.Drawing.Point(611, 50);
            this.btnPesoProdutoIncrease.Name = "btnPesoProdutoIncrease";
            this.btnPesoProdutoIncrease.Size = new System.Drawing.Size(62, 47);
            this.btnPesoProdutoIncrease.TabIndex = 12;
            this.btnPesoProdutoIncrease.Text = "Aumentar";
            this.btnPesoProdutoIncrease.UseVisualStyleBackColor = true;
            this.btnPesoProdutoIncrease.Click += new System.EventHandler(this.btnPesoProdutoIncrease_Click);
            // 
            // btnPesoProdutoDecrease
            // 
            this.btnPesoProdutoDecrease.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesoProdutoDecrease.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesoProdutoDecrease.Location = new System.Drawing.Point(686, 50);
            this.btnPesoProdutoDecrease.Name = "btnPesoProdutoDecrease";
            this.btnPesoProdutoDecrease.Size = new System.Drawing.Size(62, 47);
            this.btnPesoProdutoDecrease.TabIndex = 13;
            this.btnPesoProdutoDecrease.Text = "Diminuir";
            this.btnPesoProdutoDecrease.UseVisualStyleBackColor = true;
            this.btnPesoProdutoDecrease.Click += new System.EventHandler(this.btnPesoProdutoDecrease_Click);
            // 
            // lblPesoProdutoValue
            // 
            this.lblPesoProdutoValue.AutoSize = true;
            this.lblPesoProdutoValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPesoProdutoValue.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoProdutoValue.Location = new System.Drawing.Point(663, 120);
            this.lblPesoProdutoValue.Name = "lblPesoProdutoValue";
            this.lblPesoProdutoValue.Size = new System.Drawing.Size(30, 33);
            this.lblPesoProdutoValue.TabIndex = 14;
            this.lblPesoProdutoValue.Text = "0";
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliar.Location = new System.Drawing.Point(754, 74);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(75, 23);
            this.btnAvaliar.TabIndex = 15;
            this.btnAvaliar.Text = "Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = true;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // pbLogoPrix
            // 
            this.pbLogoPrix.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoPrix.Image")));
            this.pbLogoPrix.Location = new System.Drawing.Point(0, 0);
            this.pbLogoPrix.Name = "pbLogoPrix";
            this.pbLogoPrix.Size = new System.Drawing.Size(227, 187);
            this.pbLogoPrix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogoPrix.TabIndex = 4;
            this.pbLogoPrix.TabStop = false;
            this.pbLogoPrix.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblBalancaToledo
            // 
            this.lblBalancaToledo.AutoSize = true;
            this.lblBalancaToledo.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalancaToledo.Location = new System.Drawing.Point(325, 72);
            this.lblBalancaToledo.Name = "lblBalancaToledo";
            this.lblBalancaToledo.Size = new System.Drawing.Size(368, 42);
            this.lblBalancaToledo.TabIndex = 5;
            this.lblBalancaToledo.Text = "BALANÇA TOLEDO";
            // 
            // mpBalancaToledo
            // 
            this.mpBalancaToledo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpBalancaToledo.Controls.Add(this.lblBalancaToledo);
            this.mpBalancaToledo.Controls.Add(this.pbLogoPrix);
            this.mpBalancaToledo.HorizontalScrollbarBarColor = true;
            this.mpBalancaToledo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpBalancaToledo.HorizontalScrollbarSize = 10;
            this.mpBalancaToledo.Location = new System.Drawing.Point(1, 2);
            this.mpBalancaToledo.Name = "mpBalancaToledo";
            this.mpBalancaToledo.Size = new System.Drawing.Size(850, 187);
            this.mpBalancaToledo.Style = MetroFramework.MetroColorStyle.Purple;
            this.mpBalancaToledo.TabIndex = 16;
            this.mpBalancaToledo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mpBalancaToledo.UseCustomBackColor = true;
            this.mpBalancaToledo.VerticalScrollbarBarColor = true;
            this.mpBalancaToledo.VerticalScrollbarHighlightOnWheel = false;
            this.mpBalancaToledo.VerticalScrollbarSize = 10;
            this.mpBalancaToledo.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 373);
            this.Controls.Add(this.mpBalancaToledo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrix)).EndInit();
            this.mpBalancaToledo.ResumeLayout(false);
            this.mpBalancaToledo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaraIncrease;
        private System.Windows.Forms.Button btnTaraDecrease;
        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesoMaximoDecrease;
        private System.Windows.Forms.Button btnPesoMaximoIncrease;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.Button btnPesoMinimoDecrease;
        private System.Windows.Forms.Button btnPesoMinimoIncrease;
        private System.Windows.Forms.Label lblPesoMinimo;
        private System.Windows.Forms.Label lblTaraValue;
        private System.Windows.Forms.Label lblPesoMaximoValue;
        private System.Windows.Forms.Label lblPesoMinimoValue;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblPesoProduto;
        private System.Windows.Forms.Label lblPesoProdutoValue;
        private System.Windows.Forms.Button btnPesoProdutoDecrease;
        private System.Windows.Forms.Button btnPesoProdutoIncrease;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.PictureBox pbLogoPrix;
        private System.Windows.Forms.Label lblBalancaToledo;
        private MetroFramework.Controls.MetroPanel mpBalancaToledo;
    }
}

