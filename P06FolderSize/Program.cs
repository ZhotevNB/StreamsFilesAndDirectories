using System;
using System.IO;

namespace P06FolderSize
{
    class Program
    {
        static void Main()
        {
            string path = Console.ReadLine();
           var files= Directory.GetFiles(path);
            decimal filesSize = 0;
            foreach (var filePath in files)
            {
                FileInfo file = new FileInfo(filePath);
                filesSize += file.Length;

            }
            filesSize = filesSize / 1024 / 1024 / 1024;
            Console.WriteLine($"File Size: {Math.Round(filesSize,2)}");
            
        }

    }
}
