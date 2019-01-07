using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        /*
    * Complete the gradingStudents function below.
    */
        static int[] gradingStudents(int[] grades)
        {
            int[] arrFinal = new int[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                int margin = 2;
                if (grades[i] >= 38)
                {
                    if (grades[i] % 5 == 0)
                        arrFinal[i] = grades[i];
                    else
                    {
                        for (int j = 1; j <= margin; j++)
                            if ((grades[i] + j) % 5 == 0)
                                arrFinal[i] = (grades[i] + j);
                        if (arrFinal[i] == 0)
                            arrFinal[i] = grades[i];
                    }
                }
                else
                    arrFinal[i] = grades[i];
            }

            return arrFinal;
        }
        static void Main(string[] args)
        {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            //tw.WriteLine(string.Join("\n", result));

            //tw.Flush();
            //tw.Close();
        }
    }
}
