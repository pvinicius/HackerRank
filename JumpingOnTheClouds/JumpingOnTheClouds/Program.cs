using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Program
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int index = 0;
            int minJump = 0;

            while (index < c.Length)
            {
                if (index + 2 < c.Length && c[index + 2] == 0)
                {
                    index += 2;
                    minJump++;
                }
                else
                {
                    if (index + 1 < c.Length)
                        minJump++;

                    index++;
                }
            }

            return minJump;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll("0 0 1 0 0 1 0".Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
