using System;
using NamespaceAndAssembly.ClassLibrary;
namespace NamespaceAndAssembly.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            D classD = new D();//Class D is public for NamespaceAndAssembly.ConsoleApp assembly.
            // Here class B and C not accessible due to internal access modifier. 
            //The internal is the default access modifier in c# when you don't specify any access modifier explicitly.

            Console.WriteLine(classA.Message2); //Class A Message field not accessiable due to internal access modifier.
            Console.WriteLine(classA.GetMessageFromClassB());
            Console.WriteLine(classA.GetMessageFromClassC());
            Console.WriteLine(classD.Message);// Now class D Message field is accessiable for NamespaceAndAssembly.ConsoleApp assembly.

            Console.ReadKey();
        }
    }
}
