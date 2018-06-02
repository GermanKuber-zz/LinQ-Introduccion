using System.IO;
using System.Linq;
using static System.Console;

namespace Introduction
{
    public static class FilesManagerLinq
    {
        public static void ShowFiles(string path) => new DirectoryInfo(path)
               .GetFiles()
               .OrderByDescending(f => f.Length)
               .Take(5)
               .ToList()
               .ForEach(file => WriteLine(file.Name));
    }
}