namespace SoftServeITAcademy_Homework_4D
{
    using System;

    public class ConsoleInputValidator : IValidatable
    {
        public double GetDoubleInput(string inputQuery, double min, double max)
        {
            Console.WriteLine(inputQuery);

            double inputValue;

            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out inputValue))
                {
                    Console.Write("Enter valid double value: ");
                }
                else if (inputValue < min || inputValue > max)
                {
                    Console.Write($"Enter double in range from {min} to {max}: ");
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
