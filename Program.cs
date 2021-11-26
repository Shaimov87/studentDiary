using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = null;
            int[][] marks = null;

            Console.Write("\tPlease,enter number of subjects");
            int n = Convert.ToInt32(Console.ReadLine());
            subjects = new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"\tPlease,enter subject ({i+1}/{n}) ");
                subjects[i] = Console.ReadLine();
            }

            marks = new int[n][];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"\tPlease,enter number  marks for subject {subjects[i]} ");
                int m = Convert.ToInt32(Console.ReadLine());
                marks[i] = new int[m];
                for(int j = 0; j < m; j++)
                {
                    Console.Write($"\tPlease,enter marks ({i + 1}/{m}) ");
                    marks[i][j] = Convert.ToInt32(Console.Read());
                }
                bool key=false;
                marks[i].Average() > 2.5 && m > 2 ? key = true : key = false;            /*Console.WriteLine("\tCertified") : Console.WriteLine("\tNot Certified");*/
            }

            for(int i = 0; i < subjects.Length; i++)
            {
                Console.Write($"\t{subjects[i]}:\t\t ");
                foreach (int mark in marks[i])
                    Console.Write($"\t{mark} ");
                Console.WriteLine();
            }

            double totalSum = 0;
            for(int i = 0; i < subjects.Length; i++)
            {
                double av = marks[i].Average();
                totalSum += av;
                Console.WriteLine($"\tAverage mark of {subjects[i]} = {marks[i].Average()}");
            }
            Console.WriteLine($"\tAverage mark of study: {totalSum/subjects.Length}");
        }
    }
}
