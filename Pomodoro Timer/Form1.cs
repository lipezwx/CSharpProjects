using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Pomodoro_Timer
{
    public partial class Pomodoro: Form
    {
        public Pomodoro()
        {
            InitializeComponent();
        }

        #region Declaring Global Variables

        // Pomodoro variables
        int pSecondsCounter = 0;
        int pMinutesCounter = 0;

        // Short Break variables
        int sbSecondsCounter = 0;
        int sbMinutesCounter = 0;

        // Long Break variables
        int lbSecondsCounter = 0;
        int lbMinutesCounter = 0;

        int completedSessions = 0;
        #endregion

        private void lblSeconds_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbUserTask.Text)) 
            {
                // Starts our timer
                PomodoroTimer.Start();

                // Switch buttons from start to stop
                btnStart.Enabled = false;
                btnStart.Visible = false;
                btnStop.Enabled = true;
                btnStop.Visible = true;

                // Changes the current task label
                lblCurrentTask.TextAlign = ContentAlignment.MiddleLeft;
                lblCurrentTask.Text = $"Current Task: {tbUserTask.Text}";
            }
        }

        private void SecondsTimer_Tick(object sender, EventArgs e)
        {
            pSecondsCounter++;
            if (pSecondsCounter < 10)
                lblSeconds.Text = $"0{pSecondsCounter.ToString()}";
            else 
            {
                lblSeconds.Text = pSecondsCounter.ToString();
            }
            if (pSecondsCounter == 59) 
            {
                pSecondsCounter = 0;
                pMinutesCounter++;
                if (pMinutesCounter < 10)
                {
                    lblMinutes.Text = $"0{pMinutesCounter.ToString()}";
                }
                else 
                {
                    lblMinutes.Text = pMinutesCounter.ToString();
                }
            }

            if (pMinutesCounter == 25) 
            {
                pSecondsCounter = 0;
                PomodoroTimer.Stop();

                // Enable panel for choosing break
                flpShortOrLong.Visible = true;
                flpShortOrLong.Enabled = true;
                
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (PomodoroTimer.Enabled == true)
            {
                PomodoroTimer.Stop();
            }
            if (ShortBreakTimer.Enabled == true) 
            {
                ShortBreakTimer.Stop();
            }
            btnStart.Enabled = true;
            btnStart.Visible = true;
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentTask_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {

        }

        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            ShortBreakLCD();
        }

        private void ShortBreak_Tick(object sender, EventArgs e)
        {
            sbSecondsCounter++;
            if (sbSecondsCounter < 10)
                lblSeconds.Text = $"0{sbSecondsCounter.ToString()}";
            else
            {
                lblSeconds.Text = sbSecondsCounter.ToString();
            }
            if (sbSecondsCounter == 59)
            {
                sbSecondsCounter = 0;
                sbMinutesCounter++;

                lblMinutes.Text = $"0{sbMinutesCounter.ToString()}";

                if (sbMinutesCounter == 5)
                { 
                    lblSeconds.Text = "00";
                    ShortBreakTimer.Stop();
                }
            }
        }

        void ShortBreakLCD() 
        {
            // Set Colors to Red During the Break
            lblMinutes.ForeColor = Color.DarkRed;
            lblSeconds.ForeColor = Color.DarkRed;

            // Reset timer and add 1 to completed sessions
            completedSessions++;
            lblMinutes.Text = "00";
            lblSeconds.Text = "00";
            pMinutesCounter = 0;
            pSecondsCounter = 0;

            // Auto start again and set limit to 5 minutes
            flpShortOrLong.Enabled = false;
            flpShortOrLong.Visible = false;
            ShortBreakTimer.Start();
            
        }

        void ResetTimer() 
        {
            if (PomodoroTimer.Enabled == true) 
            {
                PomodoroTimer.Enabled = false;
                pSecondsCounter = 0;
                pMinutesCounter = 0;
                lblMinutes.Text = "00";
                lblSeconds.Text = "00";
            }
            if (ShortBreakTimer.Enabled == true) 
            {
                ShortBreakTimer.Enabled = false;
                sbSecondsCounter = 0;
                sbMinutesCounter = 0;
                lblMinutes.Text = "00";
                lblSeconds.Text = "00";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
    }
}
