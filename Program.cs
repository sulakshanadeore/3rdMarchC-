using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using ClassLibrary1;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //XMLSerializeMethod();
            //XMLDeserializeMethod();


            //BinarySerializeMethod();
            //BinaryDeserializeMethod();

            //JsonSerialiazeMethod();
            //JsonDeserializeMethod();
            Console.Read();
        }

        private static void JsonDeserializeMethod()
        {
            string data = File.ReadAllText(@"D:\Sulakshana\IBMC#\FileHandlingDemo\SerializationDemo\custdata.json");
            Customer cdata = JsonSerializer.Deserialize<Customer>(data);
            Console.WriteLine(cdata.CustomerID);
            Console.WriteLine(cdata.Cardno);
            Console.WriteLine(cdata.Amt);
            Console.WriteLine(cdata.TranDate);
        }

        private static void JsonSerialiazeMethod()
        {
            Customer c1 = new Customer();
            c1.CustomerID = 105;
            c1.Amt = 5000;
            c1.Cardno = 23423;
            c1.TranDate = new DateTime(2021, 03, 11);

            string cdata = JsonSerializer.Serialize(c1, typeof(Customer));
            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\SerializationDemo\custdata.json";
            File.WriteAllText(path, cdata);
            Console.WriteLine("Json File created..");
        }

        private static void BinaryDeserializeMethod()
        {
            BinaryFormatter bf = new BinaryFormatter();
            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\SerializationDemo\";
            Console.WriteLine("enter the customer id");
            int custid = Convert.ToInt32(Console.ReadLine());
            path = string.Concat(path, "c", custid, ".bin");
            bool ans = File.Exists(path);
            if (ans)
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                Customer c1 = (Customer)bf.Deserialize(fs);
                Console.WriteLine(c1.CustomerID);
                Console.WriteLine(c1.Amt);
                Console.WriteLine(c1.TranDate);
                Console.WriteLine(c1.Cardno);


            }
            else
            {
                Console.WriteLine("Pls check customer id");
            }
        }

        private static void BinarySerializeMethod()
        {
            BinaryFormatter bf = new BinaryFormatter();
            Customer c = new Customer();
            c.CustomerID = 103;
            c.TranDate = new DateTime(2021, 03, 09);
            c.Amt = 4000;
            c.Cardno = 24234;
            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\SerializationDemo\";
            path = string.Concat(path, "c", c.CustomerID, ".bin");
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            bf.Serialize(fs, c);
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }

        private static void XMLDeserializeMethod()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Customer));
            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\SerializationDemo\";
            Console.WriteLine("enter the customer id");
            int custid = Convert.ToInt32(Console.ReadLine());
            path = string.Concat(path, "c", custid, ".xml");
            bool ans = File.Exists(path);
            if (ans)
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                Customer cdata = (Customer)xs.Deserialize(fs);
                Console.WriteLine(cdata.CustomerID);
                Console.WriteLine(cdata.TranDate);
                Console.WriteLine(cdata.Amt);
                fs.Flush();
                fs.Close();

                fs.Dispose();

            }
            else
            {
                Console.WriteLine("Pls check ur customer id");
            }
        }

        private static void XMLSerializeMethod()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Customer));
            Customer c = new Customer();
            c.CustomerID = 102;
            c.TranDate = new DateTime(2021, 03, 09);
            c.Amt = 1000;
            //c.Cardno = 423424;

            string path = @"D:\Sulakshana\IBMC#\FileHandlingDemo\SerializationDemo\";
            path = string.Concat(path, "c", c.CustomerID, ".xml");
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            xs.Serialize(fs, c);
            fs.Flush();
            fs.Close();

            fs.Dispose();
            Console.WriteLine("File created and object written to the file");
        }
    }
}
