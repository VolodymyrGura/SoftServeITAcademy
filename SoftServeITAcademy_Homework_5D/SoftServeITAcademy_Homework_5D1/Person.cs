using System;

namespace SoftServeITAcademy_Homework_4
{
    public class Person : ICloneable
    {
        private string name;
        private int birthYear;

        public string Name { get; set; }

        public int BirthYear { get; set; }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Person()
        {
            //this.Input();
        }

        public Person(string names, int birthYears)
        {
            this.name = names;
            this.birthYear = birthYears;
        }

        public int Age()
        {
            int age = 0;
            return age = 2017 - this.birthYear;
        }

        public void Input()
        {
            Console.WriteLine("Input person name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Input person Birth of Year: ");
            this.birthYear = Convert.ToInt32(Console.ReadLine());
        }

        public void ChangeName()
        {
            this.name = "Very Young ";
        }

        public void Output()
        {
            Console.WriteLine("\n" + this.ToString());
        }

        public override string ToString()
        {
            return " Name: " + this.name + " Birthday Year " + this.birthYear;
        }

        public object Clone()
        {
            return new Person { name = this.Name, birthYear = this.BirthYear };
        }
    }
}
