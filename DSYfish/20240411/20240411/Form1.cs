using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240411
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            pictureBox.Image = imageList.Images[i % 3];
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (timer.Enabled)
        //        timer.Enabled = false;
        //    else
        //        timer.Enabled = true;
        //}

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            //MessageBox.Show(cmb.Text);
            timer.Interval = Int32.Parse(cmb.Text); 
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Enabled = true;
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            Random rd = new Random();
            pictureBox.Image = imageList.Images[rd.Next(0, 3)];
        }
        private void my_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Enabled = true;
        }

        private void my_MouseUp(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            Random rd = new Random();
            int index = rd.Next(0, 3);
            pictureBox.Image = imageList.Images[index];
            /*
             * 0 - paper
             * 1 - rock
             * 2 - scissors
             */
            int win_loose = 0;
            /*
             * 0 - even
             * 1 - win
             * 2 - loose
             */
            Button btn = (Button)sender;
            switch(btn.Text)
            {
                case "Scissors":
                    if (index == 0)
                        win_loose = 1;
                    else if (index == 1)
                        win_loose = 2;
                    else
                        win_loose = 0;
                    break;
                
                case "Paper":
                    if (index == 0)
                        win_loose = 0;
                    else if (index == 1)
                        win_loose = 1;
                    else
                        win_loose = 2;
                    break;
                
                case "Rock":
                    if (index == 0)
                        win_loose = 2;
                    else if (index == 1)
                        win_loose = 0;
                    else
                        win_loose = 1;
                    break;

            }
            if (win_loose == 0)
            {
                label_wl.Text = "ENEN";
                label_wl.ForeColor = Color.Green;
            }
            else if (win_loose == 1)
            {
                label_wl.Text = "YOU WIN";
                label_wl.ForeColor = Color.Red;
            }
            else
            {
                label_wl.Text = "YOU LOSE";
                label_wl.ForeColor = Color.Gray;
            }

        }
    }
}
