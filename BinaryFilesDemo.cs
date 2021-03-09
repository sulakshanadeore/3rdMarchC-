using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace FileHandlingDemo
{
    class BinaryFilesDemo
    {
        static void Main(string[] args)
        {
            //createbinaryfile();
            //ReadFromBinaryFile();
            FileStream fs = new FileStream(@"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\border1.jpg", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
           byte[] barr= br.ReadBytes(Convert.ToInt32(fs.Length));
            br.Close();
            fs.Close();
            //MemoryStream ms = new MemoryStream(barr);
            //Image img1=Image.FromStream(ms);
            //picturebox.image = img;
            FileStream fs1 = new FileStream(@"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\img1.jpg", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs1);
            bw.Write(barr);
            bw.Close();
            fs1.Close();






            Console.Read();

        }

        private static void ReadFromBinaryFile()
        {
            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\file2.bin";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine(br.ReadInt32());
            br.Close();
            fs.Close();
        }

        private static void createbinaryfile()
        {
            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\FileHandlingDemo\file2.bin";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(3453);
            bw.Close();
            fs.Close();
        }
    }
}
