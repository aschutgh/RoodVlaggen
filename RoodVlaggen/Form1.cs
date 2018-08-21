using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RoodVlaggen
{
    public partial class Form1 : Form
    {
        public Form1(string[] flagfiles)
        {
            //string mypath = Directory.GetCurrentDirectory();
            //Console.Write("path: " + mypath);
            InitializeComponent();
            //Mypath = mypath;
            Flagfiles = flagfiles;
            Flagidx = 0;
            pictureBox1.Load(Flagfiles[Flagidx]);

        }

        public string Mypath { get; set; }
        public string[] Flagfiles { get; set; }
        public int Flagidx { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"..\..\..\flags-normal\nl.png");
            //labelCountry.Text = Mypath;
            
            
        }

        private void previousButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (Flagidx == 0)
            {
                Flagidx = Flagfiles.Length - 1;
            }
            else
            {
                Flagidx -= 1;
            }
            pictureBox1.Load(Flagfiles[Flagidx]);
        }

        private void nextButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (Flagidx == Flagfiles.Length - 1)
            {
                Flagidx = 0;
            }
            else
            {
                Flagidx += 1;
            }
            pictureBox1.Load(Flagfiles[Flagidx]);
        }
    }
}
