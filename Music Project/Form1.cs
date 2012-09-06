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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] keys = { "A", "B", "C", "D", "E", "F", "G", "Bb", "Eb", "Gb", "Ab", "Bb"};

        public Form1()
        {
            InitializeComponent();
        }

        private void updateWithNewKey(ButtonType buttonType)
        {
            Random rnd = new Random();
            String key = keys[rnd.Next(keys.Length)];
			string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            using (SoundPlayer player = new SoundPlayer(appPath + "\\Sound\\" + key.Substring(0, 1) + ".wav"))
            {
                player.PlaySync();
            }
            if (key.Contains("b"))
            {
                using (SoundPlayer player = new SoundPlayer(appPath + "\\Sound\\" + "flat.wav"))
                {
                    player.PlaySync();
                }
            }
            switch (buttonType)
            {
                case ButtonType.Major:
                    lKeyDisplay.Text = lKeyDisplay.Text + key + " ";
                    break;
                case ButtonType.Both:
                    if (rnd.Next(2) == 1)
                    {
                        lKeyDisplay.Text = lKeyDisplay.Text + key + " ";
                    }
                    else
                    {
                        lKeyDisplay.Text = lKeyDisplay.Text + key + "m ";
                        using (SoundPlayer player = new SoundPlayer(appPath + "\\Sound\\" + "minor.wav"))
                        {
                            player.PlaySync();
                        }
                    }
                    break;
                case ButtonType.Minor:
                    lKeyDisplay.Text = lKeyDisplay.Text + key + "m ";
                    using (SoundPlayer player = new SoundPlayer(appPath + "\\Sound\\" + "minor.wav"))
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

        private void bLeft_Click_1(object sender, EventArgs e)
        {
            updateWithNewKey(ButtonType.Major);
        }

        private void bMiddle_Click_1(object sender, EventArgs e)
        {
            updateWithNewKey(ButtonType.Both);
        }

        private void bRight_Click_1(object sender, EventArgs e)
        {
            updateWithNewKey(ButtonType.Minor);
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            lKeyDisplay.Text = "";
        }

        ButtonType selectedRadial = ButtonType.Major;
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
            selectedRadial = ButtonType.Major;
        }

        private void rBoth_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = ButtonType.Both;
        }

        private void rMinor_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = ButtonType.Minor;
        }

    }
}
