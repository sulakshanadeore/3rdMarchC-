using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingDemo
{
    class FileDemo
    {
        static void Main(string[] args)
        {
            CreateFile();
            ReadFile();
            CreateNewFile();
            Console.WriteLine("enter the path to create file");
            string path = Console.ReadLine();
            createfileusingParameter(path);

            Console.Read();
        }

        private static void createfileusingParameter(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("hello ");
            sw.Close();
            fs.Close();
        }

        private static void CreateNewFile()
        {
            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\file1.txt";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("hello ");
            sw.Close();
            fs.Close();
        }

        private static void ReadFile()
        {
            FileStream fs = new FileStream(@"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\file1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }

        private static void CreateFile()
        {
            FileStream fs = new FileStream(@"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\file1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("hello ");
            sw.Close();
            fs.Close();
        }
    }
}
