using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int SockMerchant(int n, int[] ar)
        {
            int result = 0;
            HashSet<int> socks = new HashSet<int>();
            socks.Clear();
            for (int i = 0; i < n; i++)
            {
                if (!socks.Contains(ar[i]))
                {
                    socks.Add(ar[i]);
                }
                else
                {
                    result++;
                    socks.Remove(ar[i]);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int n = ar.Length;

            int result = SockMerchant(n, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
