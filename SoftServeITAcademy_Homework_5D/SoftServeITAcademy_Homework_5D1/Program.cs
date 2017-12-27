using System;

namespace SoftServeITAcademy_Homework_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;
            Person[] person = new Person[10];
            Person person0 = new Person { Name = "Vova", BirthYear = 1997 };
            for (i = 0; i < person.Length; i++)
            {
                person[i] = (Person)person0.Clone();
            }

            foreach (var data in person)
            {
                Console.WriteLine("Name: {0} Age: {1}", data.Name, data.Age());
            }

            foreach (var data in person)
            {
                if (data.Age() < 16)
                {
                    data.ChangeName();
                }
            }

            foreach (var data in person)
            {
                data.Output();
            }

            Console.WriteLine("The same names is:");

            for (i = 0; i < person.Length; ++i)
            {
                for (int j = i + 1; j < person.Length; ++j)
                {
                    if (person[i] == person[j])
                    {
                        Console.WriteLine("------" + person[i].Name + person[i].BirthYear);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
