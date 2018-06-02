using System;
using System.IO;

namespace Introduction
{
    public static class FilesManager
    {
        public static void ShowFiles(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);

            FileInfo[] files = directory.GetFiles();

            Array.Sort(files, new FileInfoComparer());

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine(file.Name);
            }
        }
    }
}