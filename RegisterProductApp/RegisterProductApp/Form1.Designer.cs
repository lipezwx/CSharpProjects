namespace RegisterProductApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnSuperiorBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.tbTension = new System.Windows.Forms.TextBox();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTension = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.Label();
            this.lblLogoSenai = new System.Windows.Forms.Label();
            this.pnSuperiorBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperiorBar
            // 
            this.pnSuperiorBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.pnSuperiorBar.Controls.Add(this.lblLogoSenai);
            this.pnSuperiorBar.Controls.Add(this.btnMinimize);
            this.pnSuperiorBar.Controls.Add(this.btnExit);
            this.pnSuperiorBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperiorBar.Location = new System.Drawing.Point(0, 0);
            this.pnSuperiorBar.Name = "pnSuperiorBar";
            this.pnSuperiorBar.Size = new System.Drawing.Size(1222, 78);
            this.pnSuperiorBar.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1108, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 53);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1162, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 53);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Barlow Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.btnRegister.Location = new System.Drawing.Point(410, 423);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(400, 140);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbProduct
            // 
            this.tbProduct.Font = new System.Drawing.Font("Barlow Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.tbProduct.Location = new System.Drawing.Point(410, 185);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(400, 36);
            this.tbProduct.TabIndex = 3;
            // 
            // tbTension
            // 
            this.tbTension.Font = new System.Drawing.Font("Barlow Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.tbTension.Location = new System.Drawing.Point(410, 254);
            this.tbTension.Name = "tbTension";
            this.tbTension.Size = new System.Drawing.Size(400, 36);
            this.tbTension.TabIndex = 4;
            // 
            // tbCurrent
            // 
            this.tbCurrent.Font = new System.Drawing.Font("Barlow Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.tbCurrent.Location = new System.Drawing.Point(410, 330);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(400, 36);
            this.tbCurrent.TabIndex = 5;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(264, 178);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(105, 43);
            this.lblProduct.TabIndex = 6;
            this.lblProduct.Text = "Product";
            // 
            // lblTension
            // 
            this.lblTension.AutoSize = true;
            this.lblTension.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTension.Location = new System.Drawing.Point(264, 254);
            this.lblTension.Name = "lblTension";
            this.lblTension.Size = new System.Drawing.Size(104, 43);
            this.lblTension.TabIndex = 7;
            this.lblTension.Text = "Tension";
            // 
            // Current
            // 
            this.Current.AutoSize = true;
            this.Current.Font = new System.Drawing.Font("Barlow Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current.Location = new System.Drawing.Point(264, 330);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(101, 43);
            this.Current.TabIndex = 8;
            this.Current.Text = "Current";
            // 
            // lblLogoSenai
            // 
            this.lblLogoSenai.AutoSize = true;
            this.lblLogoSenai.Font = new System.Drawing.Font("Barlow Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoSenai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogoSenai.Location = new System.Drawing.Point(3, 9);
            this.lblLogoSenai.Name = "lblLogoSenai";
            this.lblLogoSenai.Size = new System.Drawing.Size(123, 65);
            this.lblLogoSenai.TabIndex = 9;
            this.lblLogoSenai.Text = "SENAI";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1222, 653);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.lblTension);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.tbTension);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pnSuperiorBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Register Products";
            this.pnSuperiorBar.ResumeLayout(false);
            this.pnSuperiorBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperiorBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.TextBox tbTension;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Label lblLogoSenai;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTension;
        private System.Windows.Forms.Label Current;
    }
}

