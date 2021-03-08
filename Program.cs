using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {//Non-Generic--- object
            ArrayList list = new ArrayList();
            float h = 99.3f;
            list.Add(h);
            list.Add(2);
            list.Add("sfs");
            list.Add(new DateTime(2010,2,2));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //ArrayList l = new ArrayList();
            //Console.WriteLine("After cloning...");
            //l=(ArrayList)list.Clone();
            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}
            ArrayList copy = new ArrayList();
            object[] obj = new object[4];
            list.CopyTo(obj);
             Console.WriteLine("Object array..");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Arraylist created by copy from object []");
            copy.Add(obj);
            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }


            list.Add("new value");
            Console.WriteLine("Added element to original list");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("After adding the cloned list is...");
            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}
            //bool refEqual=Object.ReferenceEquals(list, l);
            //Console.WriteLine("r the reference equal" + refEqual);
            //ArrayList copy = new ArrayList();
            //object[] obj = new object[4];
            //list.CopyTo(obj);

            Console.WriteLine("New Object array..");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("New Arraylist created by copy from object []");
            copy.Add(obj);
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            bool refEqual = Object.ReferenceEquals(list, copy);
            Console.WriteLine("r the reference equal" + refEqual);
            int[] a1 = new int[] { 100, 200 };
            list.AddRange(a1);
            Console.WriteLine("Capacity=" +list.Capacity);

            Console.WriteLine(list.Contains("hello"));
            Console.WriteLine(list.Contains(100));
            ArrayList alist = new ArrayList();
            alist = list.GetRange(2, 3); Console.WriteLine("getrange");
            foreach (var item in alist)
            {
                Console.WriteLine(item);
            }
            //list.Insert(3, 300);
            //list.InsertRange(3, alist);

            //Stack,Queue,SortedList,ArrayList,BitArray,HashTable

            Stack s = new Stack();//LIFO
            s.Push(3);
            s.Push(89.4f); 
            s.Push("hello");
            //iterate using for each
            s.Pop();//remove last element --- removes hello
            object o=s.Peek();//89.4
            Console.WriteLine(o);
            object[] obj1=s.ToArray();
            int cnt=s.Count;//read only

            Queue q = new Queue(100);//FIFO
            q.Enqueue(22);
            q.Enqueue(23);
            q.Dequeue();
            q.Peek();
            q.TrimToSize();

            Console.WriteLine("Hash table");
            Hashtable ht = new Hashtable();
            ht.Add("1", 1);
            ht.Add(1, 1);
            ht.Add(2, "a");
            IDictionaryEnumerator ie=ht.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key +  " " + ie.Value);

            }

            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Entry.Key + "  " + ie.Entry.Value);
            }

            SortedList slist = new SortedList();
            slist.Add("100", "sdf");
            slist.Add("2", "sdf");
            slist.Add("1", "sdf");
            ie=slist.GetEnumerator();
            Console.WriteLine("Sorted List");
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key + "  " + ie.Value);
            }









            Console.Read();


        }
    }
}
