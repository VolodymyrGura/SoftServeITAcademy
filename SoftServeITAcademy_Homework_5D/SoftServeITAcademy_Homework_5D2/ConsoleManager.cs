using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServeITAcademy_Homework_5D2
{
  public class ConsoleManager : IInputOutputManager
    {
        public string Input()
        {
            string name;
            int birthYear;
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter birh Year:");
            birthYear = Convert.ToInt32(Console.ReadLine());

            return name + " " + birthYear;
        }

        public void Output(object o)
        {
            Console.WriteLine("Name: {0}", o);
        }
    }
}
