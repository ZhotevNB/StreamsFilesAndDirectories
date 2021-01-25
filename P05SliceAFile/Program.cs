using System;
using System.IO;

namespace P05SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            char pathSeparator = Path.DirectorySeparatorChar;
            string[] text = File.ReadAllText($".{pathSeparator}Documents{pathSeparator}TextFile1.txt").Split("\n");
            int starterPoint = 0;
            int buferSize=text.Length/4;
            int bufer = buferSize;

            for (int i = 0; i < 4; i++)
            {
                using (StreamWriter curentRowWriter = File.AppendText($".{pathSeparator}Documents{pathSeparator}Part-{i + 1}.txt.txt"))
                {


                    for (int j = starterPoint; j < bufer; j++)
                    {
                        curentRowWriter.Write(text[j]);
                    }
                    starterPoint += buferSize;
                    bufer += buferSize;
                }   
            }
        }
    }
}
