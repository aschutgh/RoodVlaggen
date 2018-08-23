using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



// instructies voor gebruik:
// ga naar flagpedia.net/download
// download "classical resolution" (flags-normal.zip)
// plaats de inhoud van flags-normal.zip in RoodVlaggen\flags-normal\
// vb: De Nederlandse vlag staat dus in het bestand: RoodVlaggen\flags-normal\nl.png
// verwijder de volgende bestanden (ik kan bij de countrycode de bijbehorende naam van het
// land niet vinden):
// 
// 


namespace RoodVlaggen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        static Dictionary<string, string> GetCountries(string countrycodespath)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(countrycodespath + @"\country-codes.csv"))
            {
                String line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string countryname = "";
                    string countrycode = "";

                    if (parts.Length > 2)
                    {
                        for (int i = 0; i < parts.Length - 2; i++)
                        {
                            countryname += parts[i];
                        }
                        countrycode = parts[parts.Length - 1];
                    }
                    else
                    {
                        countryname = parts[0];
                        countrycode = parts[1];
                    }

                    if (!countries.ContainsKey(countrycode))
                    {
                        countries.Add(countrycode, countryname);
                    }
                }
            }
            return countries;
        }

        [STAThread]
        static void Main()
        {
            string flagspath = @"..\..\..\flags-normal";
            string countrycodespath = @"..\..\..\country-codes";
            string[] flagfiles = Directory.GetFiles(flagspath);
            Dictionary<string, string> Countries = new Dictionary<string, string>();
            Countries = GetCountries(countrycodespath);

            //string mypath = Directory.GetCurrentDirectory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(flagfiles, Countries));
        }
    }
}
