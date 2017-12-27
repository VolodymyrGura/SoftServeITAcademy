using System;
using System.Collections.Generic;

namespace SoftServeITAcademy_Homework_5D
{
    class Program
    {


        static void Main(string[] args)
        {
            NewList list = new NewList();

            List<int> numbers = new List<int>();
            List<int> numbersLeft = new List<int>();
            List<int> numbersRight = new List<int>();
            Random random = new Random();
            int i, n, indexMedian;
            Console.Write("Enter N: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNumbers: ");
            for (i = 0; i < n; i++)
            {
                numbers.Add(random.Next(0, 10));
            }

            list.Print(numbers);

            indexMedian = (numbers.Count % 2 == 0) ? (numbers.Count / 2) : (((numbers.Count - 1) / 2) + 1);
            Console.Write("indexMedian: {0}   {1}", indexMedian, numbers[indexMedian - 1]);
            numbersRight.Add(numbers[indexMedian - 1]);
            numbers.Remove(numbers[indexMedian - 1]);
            for (i = 0; i < numbers.Count; i++)
            {
               if (numbers[i] < numbers[indexMedian - 1])
                {
                    numbersLeft.Add(numbers[i]);
                }
                else
                {
                    numbersRight.Add(numbers[i]);
                }
            }

            numbers.Clear();

            for (i = 0; i < numbersLeft.Count; i++)
            {
                numbers.Add(numbersLeft[i]);
            }

            Console.Write(" \nNew Numbers Left: ");
            list.Print(numbersLeft);

            for (i = 0; i < numbersRight.Count; i++)
            {
                numbers.Add(numbersRight[i]);
            }

            Console.Write(" \nNew Numbers Right: ");
            list.Print(numbersRight);

            Console.Write(" \nNew Numbers: ");
            list.Print(numbers);

            Console.ReadKey();
        }
    }
}
