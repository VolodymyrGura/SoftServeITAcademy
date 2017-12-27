using System;
using System.IO;

namespace SoftServeITAcademy_Homework_5D2
{
  public class FileManager : IInputOutputManager
    {
      private string filename;
        private string line;

        public string Input()
        {
            using (StreamReader stream = new StreamReader(filename))
            {
                do
                {
                    line = stream.ReadLine();
                    Console.WriteLine(line);
                }
                while (line != null);
            }

            return line;
        }

        public void Output(object o)
        {
            using (StreamReader stream = new StreamReader(filename))
            {
                do
                {
                    o = Input();
                    Console.WriteLine(o);
                }
                while (o != null);
            }
        }
    }
}
