using System;
using System.Linq;

namespace ListFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryToRead;
            string fileName;
            if (args == null || args.Length < 2)
            {
                Console.Write("Directory to Read > ");
                directoryToRead = Console.ReadLine();
                Console.Write("File Name to Write > ");
                fileName = Console.ReadLine();
            }
            else
            {
                directoryToRead = args[0];
                fileName = args[1];
            }

            if (directoryToRead == null || fileName == null || directoryToRead.Length == 0 || fileName.Length == 0) return;

            using (var fileOutput = new System.IO.StreamWriter(fileName))
            {
                foreach (var file in System.IO.Directory.GetFiles(directoryToRead))
                {
                    fileOutput.WriteLine(file.Split('\\').LastOrDefault());
                }
            }
        }
    }
}
