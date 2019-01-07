using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
            Console.ReadKey();
        }
    }
}
