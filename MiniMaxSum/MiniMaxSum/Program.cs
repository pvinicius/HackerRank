using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    class Program
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            Int64 minSum = 0;
            Int64 maxSum = 0;

            var arrOrder = arr.OrderBy(a => a).ToList();

            for (int i = 0; i < arrOrder.Count - 1; i++)
            {
                minSum += arrOrder[i];
            }
            for (int i = 1; i < arrOrder.Count; i++)
            {
                maxSum += arrOrder[i];
            }

            Console.Write(minSum + " " + maxSum);
        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
            Console.ReadKey();
        }
    }
}
