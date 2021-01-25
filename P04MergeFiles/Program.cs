using System;
using System.IO;
using System.Text;

namespace P04MergeFiles
    
{
    class Program
    {
        static void Main()
        {
            char pathSeparator = Path.DirectorySeparatorChar;
            StringBuilder text = new StringBuilder();
            using (StreamReader firstInput=new StreamReader($".{pathSeparator}Documents{pathSeparator}Input1.txt"))

            {
                using (StreamReader secondInput = new StreamReader($".{pathSeparator}Documents{pathSeparator}Input2.txt"))
                {
                    string firstInputRow = firstInput.ReadLine();
                    string secondInputRow = secondInput.ReadLine();
                    while (firstInputRow!=null&&secondInput!=null)
                    {
                        if (firstInputRow!=null)
                        {
                            text.AppendLine(firstInputRow);
                        }
                        if (secondInputRow!=null)
                        {
                            text.AppendLine(secondInputRow);
                        }
                        firstInputRow = firstInput.ReadLine();
                        secondInputRow = secondInput.ReadLine();

                    }
                }
            }
            using (StreamWriter output=new StreamWriter($".{pathSeparator}Documents{pathSeparator}Output.txt"))
            {
                output.Write(text.ToString());
            }
        }
    }
}
