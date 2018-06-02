using System;
using System.IO;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            FilesManager.ShowFiles(path);

            Console.WriteLine("***");

            FilesManagerLinq.ShowFiles(path);

            Console.ReadKey();
        }

    }
}
