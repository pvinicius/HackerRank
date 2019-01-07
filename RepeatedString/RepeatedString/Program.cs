using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long quociente = n / s.Length;
            long resto = n % s.Length;
            long aCount = 0;

            if ((s.Length == 1) && (s.ElementAt(0) == 'a'))
                return n;

            for (int i = 0; i < s.Length; i++)
            {
                if (s.ElementAt(i) == 'a')
                    aCount++;
            }

            aCount = aCount * quociente;
            for (int i = 0; i < resto; i++)
            {
                if (s.ElementAt(i) == 'a')
                    aCount++;
            }

            return aCount;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = "aba";

            long n = 10;

            long result = repeatedString(s, n);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
