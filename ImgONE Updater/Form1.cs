using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgONE_Updater
{
    public partial class Form1 : Form
    {
        string link = "https://github.com/Gigawiz/ImgONE/releases/download/9/ImgONE-r9.exe";
        public Form1()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Marquee;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = "http://www.imgone.co/images/app_image.png";
            }
            catch
            {
                pictureBox1.Image = ImgONE_Updater.Properties.Resources.imgone1;
            }
            progressBar1.Style = ProgressBarStyle.Continuous;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
