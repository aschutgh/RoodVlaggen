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
        public Form1(string[] flagfiles, Dictionary<string, string> countries)
        {
            //string mypath = Directory.GetCurrentDirectory();
            //Console.Write("path: " + mypath);
            InitializeComponent();
            //Mypath = mypath;
            Flagfiles = flagfiles;
            Flagidx = 0;
            Countries = countries;
            pictureBox1.Load(Flagfiles[Flagidx]);

            //voorbeeld code om een string te splitsen
            //string[] RomSplit;
            //string[] sep = new string[] { invdig };
            //RomSplit = RomGet.Split(sep, StringSplitOptions.None);
            //RomGet = String.Join("", RomSplit);

            //string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            //string value = "The handsome, energetic, young dog was playing with his smaller, more lethargic litter mate.";
            //string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var word in words)
            //    Console.WriteLine(word);

            string[] separators = { @"\", "." };
            string[] parts;
            parts = Flagfiles[Flagidx].Split(separators, StringSplitOptions.None);
            var countrycode = parts[parts.Length - 2].ToUpper();
            labelCountry.Text = Countries[countrycode];

        }

        public string Mypath { get; set; }
        public string[] Flagfiles { get; set; }
        public int Flagidx { get; set; }
        public Dictionary<string, string> Countries { get; set; }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Load(@"..\..\..\flags-normal\nl.png");
        //}

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
