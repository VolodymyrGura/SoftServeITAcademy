using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeITAcademy_Homework_5D
{
    class NewList
    {

        public  void Print(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(" {0} ", numbers[i]);
            }
        }

        public void Add(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Add(numbers[i]);
            }
        }


    }
}
