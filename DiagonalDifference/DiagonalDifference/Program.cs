using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            int indexLeft = 0;
            int indexRigth = arr.Length - 1;

            for (int i = 0; i < arr.Length; i++)
            {
                leftDiagonal += arr[i][indexLeft++];
                rightDiagonal += arr[i][indexRigth--];
            }

            if (leftDiagonal > rightDiagonal)
                return leftDiagonal - rightDiagonal;

            return rightDiagonal - leftDiagonal;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
