using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int seaLevel = 0;
            int valleys = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U') seaLevel++;
                if (s[i] == 'D') seaLevel--;

                if (seaLevel == 0 && s[i] == 'U')
                    valleys++;
            }

            return valleys;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 8;

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
