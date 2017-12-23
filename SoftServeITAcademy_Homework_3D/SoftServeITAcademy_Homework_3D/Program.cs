using System;

namespace SoftServeITAcademy_Homework_3D
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Task 1
            int i;
            double a, suma = 0;
            double[] b = new double[30] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            for (i = 0; i < 30; i++)
            {
                if (i % 2 == 0)
                {
                    a = i / 2;
                }
                else
                {
                    a = i;
                }

                suma = (a - b[i]) * (a - b[i]);
            }

            Console.WriteLine("Suma= {0}", suma);

            // Task 2
            Console.Write("Enter N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                sum += i;
                Console.Write(" {0} {1}\n", i, sum);
            }

            Console.ReadKey();
        }
    }
}
