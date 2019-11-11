using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Array_2D_DS
{
    class Program
    {
        //Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int temp =
                        arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                        arr[i + 1][j + 1] +
                        arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    maxSum = Math.Max(temp, maxSum);
                }
            }

            return maxSum;
        }

        static void Main(string[] args)
        {
            var objVet = new object[]
            {
                new { nome = "Huguinho", idade = 10 },
                new { nome = "Zezinho", idade = 12 },
                new { nome = "Luizinho", idade = 10 }
            };

            JavaScriptSerializer js = new JavaScriptSerializer();
            string strJson = js.Serialize(objVet);

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int[][] arr = new int[6][];

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            //int result = hourglassSum(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
