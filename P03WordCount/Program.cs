using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P03WordCount
{
    class Program
    {
        static void Main()
        {
            char pathSeparator = Path.DirectorySeparatorChar;

            Dictionary<string, int> wordsForCompear = new Dictionary<string, int>();
            using (StreamReader strim = new StreamReader($".{pathSeparator}Documents{pathSeparator}Words.txt"))
            {
                string[] readedStream = strim.ReadToEnd().Split();
                foreach (var word in readedStream)
                {
                    if (!wordsForCompear.ContainsKey(word))
                    {
                        wordsForCompear.Add(word, 0);
                    }
                }
            }
            using (StreamReader inputStream = new StreamReader($".{pathSeparator}Documents{pathSeparator}Input.txt"))
            {
                string curentRow = inputStream.ReadLine();
                while (curentRow != null)
                {
                    string[] unusedSimbols = new string[]
                    {
                        "-","."," ",", "
                    };
                    string[] curentRowElements = curentRow.Split(unusedSimbols,StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in curentRowElements)
                    {
                        if (wordsForCompear.ContainsKey(word.ToLower()))
                        {
                            wordsForCompear[word.ToLower()]++;
                        }
                    }
                    curentRow = inputStream.ReadLine();
                }
                wordsForCompear = wordsForCompear.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, b => b.Value);
            }
            StringBuilder text = new StringBuilder();
            foreach (var item in wordsForCompear)
            {
                text.AppendLine($"{item.Key} - {item.Value}");
            }
            using (StreamWriter output=new StreamWriter($".{pathSeparator}Documents{pathSeparator}Output.txt"))
            {
                output.Write(text.ToString());
            }


        }
    }
}
