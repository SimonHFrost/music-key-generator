using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] keys = { "A", "B", "C", "D", "E", "F", "G", "Bb", "Eb", "Gb", "Ab", "Bb"};

        public Form1()
        {
            InitializeComponent();

        }

        private void updateWithNewKey(int i)
        {
            Random rnd = new Random();
            String key = keys[rnd.Next(keys.Length)];
            using (SoundPlayer player = new SoundPlayer("C:\\Users\\Peen\\Documents\\Visual Studio 2010\\Projects\\Music Project\\" + key.Substring(0, 1) + ".wav"))
            {
                player.PlaySync();
            }
            if (key.Contains("b"))
            {
                using (SoundPlayer player = new SoundPlayer("C:\\Users\\Peen\\Documents\\Visual Studio 2010\\Projects\\Music Project\\flat.wav"))
                {
                    player.Play();
                }
            }
            switch (i)
            {
                // Major
                case 1:
                    lKeyDisplay.Text = lKeyDisplay.Text + key + " ";
                    break;
                // Minor
                case 2:
                    if (rnd.Next(2) == 1)
                    {
                        lKeyDisplay.Text = lKeyDisplay.Text + key + " ";
                    }
                    else
                    {
                        lKeyDisplay.Text = lKeyDisplay.Text + key + "m ";
                        using (SoundPlayer player = new SoundPlayer("C:\\Users\\Peen\\Documents\\Visual Studio 2010\\Projects\\Music Project\\minor.wav"))
                        {
                            player.PlaySync();
                        }
                    }
                    break;
                // Both
                case 3:
                    lKeyDisplay.Text = lKeyDisplay.Text + key + "m ";
                    using (SoundPlayer player = new SoundPlayer("C:\\Users\\Peen\\Documents\\Visual Studio 2010\\Projects\\Music Project\\minor.wav"))
                    {
                        player.PlaySync();
                    }
                    break;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lKeyDisplay.Text = "";
        }

        private void weeeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lKeyDisplay.Text = "All your zombies are belong to us...              ...us                     ...us               ...us                         ...us";
        }

        private void bLeft_Click_1(object sender, EventArgs e)
        {
            updateWithNewKey(1);
        }

        private void bMiddle_Click_1(object sender, EventArgs e)
        {
            updateWithNewKey(2);
        }

        private void bRight_Click_1(object sender, EventArgs e)
        {
            updateWithNewKey(3);
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            lKeyDisplay.Text = "";
        }

        int selectedRadial = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                button1.BackColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                timer1.Enabled = true;
                button1.BackColor = Color.FromArgb(128, 128, 255);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateWithNewKey(selectedRadial);
        }

        private void rMajor_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = 1;
        }

        private void rBoth_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = 2;
        }

        private void rMinor_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = 3;
        }

        private void editIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public static void TimeCallBack(object o)
        {

        }
    }
}
