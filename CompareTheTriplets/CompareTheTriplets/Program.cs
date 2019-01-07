using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int[] arrPoint = new int[] { 0, 0 };

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    arrPoint[0]++;

                if (a[i] < b[i])
                    arrPoint[1]++;
            }

            return new List<int>(arrPoint);
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
