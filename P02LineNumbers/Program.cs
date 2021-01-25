using System;
using System.IO;
using System.Text;

namespace P02LineNumbers
{
    class Program
    {
       

        static void Main()
        {
            char pathSeparator = Path.DirectorySeparatorChar;
            
            using (StreamReader readedText=new StreamReader($".{pathSeparator}Documents{pathSeparator}Input.txt"))
            {
                StringBuilder text = new StringBuilder();
                string curentRow = readedText.ReadLine();
                int rowNumber = 1;
                while (curentRow!=null)
                {
                    text.AppendLine($"{rowNumber}. {curentRow}");
                    rowNumber++;
                    curentRow = readedText.ReadLine();
                }
                using (StreamWriter output = new StreamWriter($".{pathSeparator}Documents{pathSeparator}Output.txt"))
                {
                    output.Write(text.ToString());
                }
            }
        }
    }
}
