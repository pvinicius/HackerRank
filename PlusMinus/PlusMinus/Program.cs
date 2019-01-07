using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            double arrLength = arr.Length;
            double countPositive = 0;
            double countNegative = 0;
            double countZero = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    countPositive++;
                }
                else
                {
                    if (arr[i] < 0)
                    {
                        countNegative++;
                    }
                    else
                    {
                        if (arr[i] == 0)
                        {
                            countZero++;
                        }
                    }
                }
            }
            double resultPositive = countPositive / arrLength;
            double resultNegative = countNegative / arrLength;
            double resultZero = countZero / arrLength;

            Console.WriteLine(resultPositive);
            Console.WriteLine(resultNegative);
            Console.WriteLine(resultZero);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
            Console.ReadKey();
        }
    }
}
