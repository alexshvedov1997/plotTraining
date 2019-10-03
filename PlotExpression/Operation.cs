using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PlotExpression
{
    class Operation
    {
        public static double Formula(double x)
        {
            return Math.Sin(x) * Math.Pow(Math.E, 4) / 5;

        }

        public static void writeInFile(string path, List<double> lst)
        {
            using (StreamWriter wtr = new StreamWriter(path)) {
                foreach (double z in lst) {
                    string wrt = z + "\r\n";
                    wtr.Write(wrt);
                }
            }
        
        }
    }
}
