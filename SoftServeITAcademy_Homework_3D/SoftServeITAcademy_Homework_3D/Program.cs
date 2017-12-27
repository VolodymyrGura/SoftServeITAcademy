using System;
using SostServeITAcademy_Homework_1;

namespace SoftServeITAcademy_Homework_3D
{
    public class Program
    {
        private static IValidatable _validator;

        public static void Main()
        {
            // Task 1
            int i;
            double suma = 0;
            double[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            for (i = 0; i < b.Length; i++)
            {
                double a;
                if (i % 2 == 0)
                {
                    a = i / 2d;
                }
                else
                {
                    a = i;
                }

                suma = Math.Pow(a - b[i], 2);
            }

            Console.WriteLine($"Sum = {suma}");

            // Task 2
            _validator = new ConsoleInputValidator();
            var n = _validator.GetIntegerInput("Enter N = ", 0, int.MaxValue);
            var sum = 0;

            for (i = 0; i < n; i++)
            {
                sum += i;
                Console.Write($" {i} {sum} \n");
            }

            Console.ReadKey();
        }
    }
}
