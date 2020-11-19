using System;
using System.Collections.Generic;
using System.IO;

namespace FilesAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\mammu\samples";
            string[] files = Directory.GetFiles(rootPath, "*.*",SearchOption.AllDirectories);
            List<string> lines = new List<string>();
            foreach(string file in files)
            {
                Console.WriteLine(file);
                var fileData = new FileInfo(file);
                Console.WriteLine(fileData);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                Console.WriteLine($"File name: {fileName}; location: {fileDirectory}; Size {fileSize}");
                string line = ($"File name: {fileName}; location: {fileDirectory}; Size {fileSize} bytes");
                lines.Add(line);

            }

            string fileDataPath = @"C:\Users\mammu\samples\FileData.txt";
            File.WriteAllLines(fileDataPath, lines);
        }
    }
}
