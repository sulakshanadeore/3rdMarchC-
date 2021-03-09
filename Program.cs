using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\abc.txt";
            
            //List<string> contents = new List<string>();
            //contents.Add("Hello first file snksfskfkslkfj");
            //File.AppendAllLines(path, contents);
            //Console.WriteLine("File created with contents");
            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\xyz.txt";
            string path1 = @"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\copyofxyz.txt";
            //File.AppendAllText(path, "Hello from xyz for file creation");

            

            //File.Copy(path, path1);
            string movepath= @"C:\Users\deore\Desktop\movedFile.txt";
            //File.Move(path1, movepath);

            //Console.WriteLine("File created with contents");
            //File.Delete(movepath);
            //Console.WriteLine("file deleted");
            //bool ans=File.Exists(movepath);
            //Console.WriteLine("File exists= " + ans);

            //DateTime dt=File.GetCreationTime(path);

            //Console.WriteLine(dt.ToLongTimeString());
            //string datainFile=File.ReadAllText(path);
            //Console.WriteLine(datainFile);

            string dirpath = @"C:\Users\deore\Desktop\NewDirectory";
            Directory.CreateDirectory(dirpath);
            Console.WriteLine("created dir");
            IEnumerable<string> dirlist;  dirlist=Directory.EnumerateDirectories(@"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\");

            foreach (string item in dirlist)
            {
                Console.WriteLine(item);
                IEnumerable<string> files=Directory.EnumerateFiles(item);
                foreach (var filename in files)
                {
                    Console.WriteLine("file Name" + filename);
                }
                
            }
            string rootdir=Directory.GetDirectoryRoot(path);
            Console.WriteLine("Root dir=" + rootdir);

            DriveInfo dinfo = new DriveInfo("D");
            Console.WriteLine(  "Available Free space " + dinfo.AvailableFreeSpace);
            Console.WriteLine("Drive Format " + dinfo.DriveFormat);
            Console.WriteLine("Type " + dinfo.DriveType);
            Console.WriteLine("Free sapce " 
                + dinfo.TotalFreeSpace);

            DirectoryInfo dirinfo = new DirectoryInfo(@"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo");
            FileInfo[] finfo=dirinfo.GetFiles();
            Console.WriteLine("File info using dirinfo.getfiles");
            foreach (var item in finfo)
            {
                Console.WriteLine(item.FullName);
                Console.WriteLine(item.Extension);
                Console.WriteLine(item.CreationTime);
            }
            Console.Read();




        }
    }
}
