using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace download
{
    public partial class installer : Form
    {
        public installer()
        {
            InitializeComponent();
        }
        int ml3e = 0;
        Random r = new Random();
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.LightGray;
            if(ml3e == 0 && r.Next() % 10 != 0)
            {
                ml3e = 1;
                label3.Location = new Point(label3.Location.X - 200, label3.Location.Y);
            }
            else if(ml3e == 1)
            {
                ml3e = 0;
                label3.Location = new Point(471, 417);
            }

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = SystemColors.Menu;
        }
        int count = 1;
        private void MainF_Tick(object sender, EventArgs e)
        {
            count++;
            if (progressBar1.Visible == true)
            {
                if (count % 600 == 0)
                {
                    progressBar1.Value = 85;
                }
                if (count % 700 == 0)
                {
                    progressBar1.Value = 0;
                }
                if (count % 2 == 0)
                {
                    progressBar1.Value++;
                }
                if (count % 100 == 0)
                {
                    progressBar1.Value = progressBar1.Value + 10;
                }
                if (progressBar1.Value >= 10)
                {
                    if (count % 20  == 0)
                    {
                        progressBar1.Value -= 5;
                    }
                    if (count % 10 == 0)
                    {
                        progressBar1.Value -= 1;
                    }
                    if (count % 1 == 0)
                    {
                        progressBar1.Value += 1;
                    }
                    if (count % 1000 == 0)
                    {
                        progressBar1.Value = 1;
                    }
                }
                if (progressBar1.Value > 50 && progressBar1.Value < 79)
                {
                    progressBar1.Value++;
                    if (count % 10 == 0)
                    {
                        progressBar1.Value -= 10;
                    }
                    else if (count % 15 == 0)
                    {
                        progressBar1.Value += 20;
                    }
                }
                if (progressBar1.Value > 90)
                {
                        progressBar1.Value -= 50;
                }
                label6.Text = count / 3600 + "時" + count / 60 + "分" + count % 60 + "秒後にダウンロードは終了します";
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = true;


        }
    }
}
