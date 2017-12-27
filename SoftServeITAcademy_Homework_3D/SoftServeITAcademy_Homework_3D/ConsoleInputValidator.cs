namespace SostServeITAcademy_Homework_1
{
    using System;

    public class ConsoleInputValidator : IValidatable
    {
        public int GetIntegerInput(string inputQuery, int min, int max)
        {
            Console.WriteLine(inputQuery);

            int inputValue;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out inputValue))
                {
                    Console.Write("Enter valid integer value: ");
                }
                else if (inputValue < min || inputValue > max)
                {
                    Console.Write($"Enter integer in range from {min} to {max}: ");
                }
                else
                {
                    break;
                }
            }

            return inputValue;
        }
    }
}
