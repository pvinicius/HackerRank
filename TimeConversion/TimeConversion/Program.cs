using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        /*
         * Complete the timeConversion function below.
         */
        static string timeConversion(string s)
        {
            var dtHour = Convert.ToDateTime(s);
            string militaryTime = dtHour.ToString("HH:mm:ss");

            return militaryTime;
        }

        static void Main(string[] args)
        {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            //tw.WriteLine(result);

            //tw.Flush();
            //tw.Close();
        }
    }
}
