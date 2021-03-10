using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesDemo
{
   

    class MetaDataDemo
    {


        static void Main(string[] args)
        {

            string path = @"D:\Sulakshana\IBMC#\CustomAttributesDemo\ReflectionDemo\bin\Debug\ReflectionDemo.dll";
            Assembly asm = Assembly.LoadFrom(path);

            Type[] type1 = asm.GetTypes();

            Type n = null;
            foreach (var item2 in type1)
            {
                n = item2;
                //Console.WriteLine(typeof(type1));

                //Type type1 = typeof(item.Name)

                // Console.WriteLine(type1);
                MethodInfo[] minfo = item2.GetMethods();
                foreach (var item in minfo)
                {

                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.IsPublic);
                    Console.WriteLine(item.IsVirtual);
                    Console.WriteLine(item.ReturnType);
                    ParameterInfo[] pinfo = item.GetParameters();
                    foreach (var p_info in pinfo)
                    {
                        Console.WriteLine(p_info.Name);
                        Console.WriteLine(p_info.GetType());
                        Console.WriteLine(p_info.Position);
                        Console.WriteLine(p_info.ParameterType);

                    }
                    Console.WriteLine("-----------");

                }


            }
            Console.WriteLine("Create Instance");
            object t = Activator.CreateInstance(n);
            
            Type tdata = asm.GetType(t.ToString());

             tdata.InvokeMember("Foo", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, t, new object[] { 10,20 });
            Console.Read();
        }

           
        }
    }

