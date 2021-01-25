using System;
using System.IO;

namespace P01OddLines
{
    class Program
    {
        static void Main()
        {
            char pathSeparator = Path.DirectorySeparatorChar;
           
          using (StreamReader reader = new StreamReader($".{pathSeparator}TextFile1.txt"))
            {
                int index = 0;
                string textLine = reader.ReadLine();
                while (textLine!=null)
                {
                   
                    if (index % 2 != 0)
                    {
                        Console.WriteLine(textLine);
                    }
                    index++;
                    textLine = reader.ReadLine();
                }

            }
        }
    }
}
