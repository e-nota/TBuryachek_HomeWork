using System;
using System.Reflection;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "d:\\Courses\\TBuryachek_HomeWork\\HomeWork6\\HomeWork6\\bin\\Debug\\net5.0\\HomeWork6.dll";
                Assembly asm = Assembly.LoadFrom(path);
                Type t = asm.GetType("HomeWork6.Figure", true, true);
                object obj = Activator.CreateInstance(t);

                MethodInfo method = t.GetMethod("Display");

                object result = method.Invoke(obj, new object[] { "Call Figure" });
                Console.WriteLine((result));
                //
                var myType = obj.GetType();

                Console.WriteLine("\n Properties:");
                foreach (var property in myType.GetProperties())
                {
                    Console.WriteLine($"{property.Name} - {property.GetValue(obj)}");
                }

                //
                Console.WriteLine("\n Methods:");
                foreach (var met in myType.GetMethods())
                {
                    Console.WriteLine($"{met.Name}");
                }

                //
                Console.WriteLine("\n Fields:");
                foreach (var f in myType.GetFields())
                {
                    Console.WriteLine($"{f.Name} - {f.GetValue(obj)}");
                }

                var myFields = myType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (var f in myFields)
                {
                    Console.WriteLine($"{f.Name} - {f.GetValue(obj)}");
                }
                //
                Console.WriteLine("\n Constructors:");
                foreach (ConstructorInfo ctor in myType.GetConstructors())
                {
                    Console.Write(myType.Name + " (");
                    ParameterInfo[] parameters = ctor.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }
                //
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
