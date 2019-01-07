using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            int maxCandle = 0;
            int countCandle = 0;
            ar = ar.OrderByDescending(a => a).ToArray();

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] >= maxCandle)
                {
                    maxCandle = ar[i];
                    countCandle++;
                }
            }
            return countCandle;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = birthdayCakeCandles(ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
