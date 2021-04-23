using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //setup sounds
            SoundPlayer countdownBeep = new SoundPlayer(Properties.Resources.countdownBeep);
            SoundPlayer startBeep = new SoundPlayer(Properties.Resources.startBeep);
            SoundPlayer startNoise = new SoundPlayer(Properties.Resources.play);

            //Clear the screen
            startButton.Visible = false;
            startNoise.Play();

            //waits 0.7 seconds
            Refresh();
            Thread.Sleep(700);

            //Countdown becomes visible
            countdownBeep.Play();
            staticCountdownLabel.Visible = true;
            countdownLabel.Visible = true;

            //waits 1 second
            Refresh();
            Thread.Sleep(1000);

            //Changes countdown to 2
            countdownBeep.Play();
            countdownLabel.Text = "2";
            
            //waits 1 second
            Refresh();
            Thread.Sleep(1000);

            //Changes coundown to 1
            countdownBeep.Play();
            countdownLabel.Text = "1";

            //waits 1 second
            Refresh();
            Thread.Sleep(1000);

            //clear screen
            staticCountdownLabel.Visible = false;
            countdownLabel.Visible = false;

            //set Final screen
            startBeep.Play();
            goLabel.Visible = true;
            this.BackColor = Color.DarkCyan;
        }
    }
}
