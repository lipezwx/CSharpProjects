namespace Pomodoro_Timer
{
    partial class Pomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTopbar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbUserTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.PomodoroTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.lblCurrentTask = new System.Windows.Forms.Label();
            this.lblTwoDots = new System.Windows.Forms.Label();
            this.flpShortOrLong = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEndedSession = new System.Windows.Forms.Label();
            this.btnShortBreak = new System.Windows.Forms.Button();
            this.btnLongBreak = new System.Windows.Forms.Button();
            this.ShortBreakTimer = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.pnTopbar.SuspendLayout();
            this.flpShortOrLong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.Font = new System.Drawing.Font("DS-Digital", 180F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(414, 177);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(348, 263);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "00";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Font = new System.Drawing.Font("DS-Digital", 180F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(768, 177);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(348, 263);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "00";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeconds.Click += new System.EventHandler(this.lblSeconds_Click);
            // 
            // flpSidebar
            // 
            this.flpSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(122)))));
            this.flpSidebar.Location = new System.Drawing.Point(0, 100);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Size = new System.Drawing.Size(261, 622);
            this.flpSidebar.TabIndex = 2;
            // 
            // pnTopbar
            // 
            this.pnTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.pnTopbar.Controls.Add(this.btnMinimize);
            this.pnTopbar.Controls.Add(this.btnExit);
            this.pnTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopbar.Location = new System.Drawing.Point(0, 0);
            this.pnTopbar.Name = "pnTopbar";
            this.pnTopbar.Size = new System.Drawing.Size(1280, 100);
            this.pnTopbar.TabIndex = 0;
            this.pnTopbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(216)))), ((int)(((byte)(168)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1150, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(56, 58);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(216)))), ((int)(((byte)(168)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1212, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbUserTask
            // 
            this.tbUserTask.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserTask.Location = new System.Drawing.Point(413, 494);
            this.tbUserTask.Name = "tbUserTask";
            this.tbUserTask.Size = new System.Drawing.Size(682, 39);
            this.tbUserTask.TabIndex = 3;
            this.tbUserTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.label1.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(486, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 100);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pomo Rush";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(1101, 494);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(45, 39);
            this.btnStart.TabIndex = 7;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PomodoroTimer
            // 
            this.PomodoroTimer.Interval = 1;
            this.PomodoroTimer.Tick += new System.EventHandler(this.SecondsTimer_Tick);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(1101, 494);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 39);
            this.btnStop.TabIndex = 8;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblCurrentTask
            // 
            this.lblCurrentTask.AutoSize = true;
            this.lblCurrentTask.Font = new System.Drawing.Font("DS-Digital", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(122)))));
            this.lblCurrentTask.Location = new System.Drawing.Point(413, 573);
            this.lblCurrentTask.Name = "lblCurrentTask";
            this.lblCurrentTask.Size = new System.Drawing.Size(405, 63);
            this.lblCurrentTask.TabIndex = 9;
            this.lblCurrentTask.Text = "Insert a Task";
            this.lblCurrentTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentTask.Click += new System.EventHandler(this.lblCurrentTask_Click);
            // 
            // lblTwoDots
            // 
            this.lblTwoDots.Font = new System.Drawing.Font("DS-Digital", 159.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoDots.Location = new System.Drawing.Point(717, 187);
            this.lblTwoDots.Name = "lblTwoDots";
            this.lblTwoDots.Size = new System.Drawing.Size(91, 223);
            this.lblTwoDots.TabIndex = 10;
            this.lblTwoDots.Text = ":";
            this.lblTwoDots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpShortOrLong
            // 
            this.flpShortOrLong.BackColor = System.Drawing.Color.Transparent;
            this.flpShortOrLong.Controls.Add(this.lblEndedSession);
            this.flpShortOrLong.Controls.Add(this.btnShortBreak);
            this.flpShortOrLong.Controls.Add(this.btnLongBreak);
            this.flpShortOrLong.Enabled = false;
            this.flpShortOrLong.Location = new System.Drawing.Point(404, 322);
            this.flpShortOrLong.Name = "flpShortOrLong";
            this.flpShortOrLong.Size = new System.Drawing.Size(742, 248);
            this.flpShortOrLong.TabIndex = 11;
            this.flpShortOrLong.Visible = false;
            this.flpShortOrLong.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblEndedSession
            // 
            this.lblEndedSession.Font = new System.Drawing.Font("DS-Digital", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndedSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(122)))));
            this.lblEndedSession.Location = new System.Drawing.Point(3, 0);
            this.lblEndedSession.Name = "lblEndedSession";
            this.lblEndedSession.Size = new System.Drawing.Size(739, 129);
            this.lblEndedSession.TabIndex = 12;
            this.lblEndedSession.Text = "You\'ve completed a session";
            this.lblEndedSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.btnShortBreak.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(228)))));
            this.btnShortBreak.Location = new System.Drawing.Point(3, 132);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(355, 79);
            this.btnShortBreak.TabIndex = 13;
            this.btnShortBreak.Text = "Short Break";
            this.btnShortBreak.UseVisualStyleBackColor = false;
            this.btnShortBreak.Click += new System.EventHandler(this.btnShortBreak_Click);
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.btnLongBreak.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(228)))));
            this.btnLongBreak.Location = new System.Drawing.Point(364, 132);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(371, 79);
            this.btnLongBreak.TabIndex = 14;
            this.btnLongBreak.Text = "Long Break";
            this.btnLongBreak.UseVisualStyleBackColor = false;
            this.btnLongBreak.Click += new System.EventHandler(this.btnLongBreak_Click);
            // 
            // ShortBreakTimer
            // 
            this.ShortBreakTimer.Interval = 1;
            this.ShortBreakTimer.Tick += new System.EventHandler(this.ShortBreak_Tick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(1152, 494);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 39);
            this.btnReset.TabIndex = 12;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTwoDots);
            this.Controls.Add(this.lblCurrentTask);
            this.Controls.Add(this.tbUserTask);
            this.Controls.Add(this.flpSidebar);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnTopbar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.flpShortOrLong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pomodoro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pomodoro_Load);
            this.pnTopbar.ResumeLayout(false);
            this.flpShortOrLong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.Panel pnTopbar;
        private System.Windows.Forms.TextBox tbUserTask;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer PomodoroTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblCurrentTask;
        private System.Windows.Forms.Label lblTwoDots;
        private System.Windows.Forms.FlowLayoutPanel flpShortOrLong;
        private System.Windows.Forms.Label lblEndedSession;
        private System.Windows.Forms.Button btnShortBreak;
        private System.Windows.Forms.Button btnLongBreak;
        private System.Windows.Forms.Timer ShortBreakTimer;
        private System.Windows.Forms.Button btnReset;
    }
}

