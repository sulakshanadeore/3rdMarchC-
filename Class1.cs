using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCollectionDemo;
namespace GenericCollections
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //ArrayList---- List
            //HashTable----Dictionary
            //Stack---- Stack
            //Queue----Queue
            List<int> listint = new List<int>();
            List<Customer> custlist = new List<Customer>();
            custlist.Add(new Customer {Custid=1,Custname="Ganesh",City="Pune" });
            Customer c = new Customer();
            c.Custid = 2;
            c.Custname = "P";
            c.City = "Mumbai";
            custlist.Add(c);
            custlist.Add(new Customer(3, "Ajay", "Pune"));

            foreach (var item in custlist)
            {
                Console.WriteLine(item.Custid);
                Console.WriteLine(item.Custname);
                Console.WriteLine(item.City);
            }

            //Stack<int>
            //Queue<T>
            Dictionary<int, Customer> d = new Dictionary<int, Customer>();
            d.Add(1, new Customer {Custid=4,Custname="Kajal",City="Pune" });

            Console.WriteLine("Dictionary...");
            Dictionary<int,Customer>.Enumerator data=d.GetEnumerator();
            while (data.MoveNext())
            {
                Console.WriteLine(data.Current.Key + "  " + data.Current.Value.Custid + " " + data.Current.Value.Custname + " " + data.Current.Value.City);
            }
            Console.Read();


        }
    }
}

