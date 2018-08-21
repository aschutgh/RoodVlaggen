using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RoodVlaggen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            string flagspath = @"..\..\..\flags-normal";
            string countrycodespath = @"..\..\..\country-codes";
            string[] flagfiles = Directory.GetFiles(flagspath);



            //string mypath = Directory.GetCurrentDirectory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(flagfiles));
        }
    }
}
