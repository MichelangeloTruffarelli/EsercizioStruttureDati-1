using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioStruttureDati_1
{
    class Program
    {
        private const string file = @"file.txt";
        private const string file1 = @"file1.txt";

        static void Main(string[] args)
        {
            List<double> numeri = new List<double>();
            using (StreamReader rfile = new StreamReader(file))
            {
                string sline;
                while ((sline = rfile.ReadLine()) != null)
                {
                    double d = Convert.ToDouble(sline);
                    numeri.Add(d);
                }
            }
            using (StreamWriter swfile = new StreamWriter(file1, true))
            {
                for (int i = numeri.Count - 1; i >= 0; i--)
                {
                    swfile.WriteLine(numeri[i]);
                }
            }
        }
    }
}
