using System;

namespace TestJenkinsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is test app\n");

            Console.Write("Enter first number: ");
            var n1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter secondNumbe: ");
            var n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Result = {n1 * n2}");
            Console.ReadKey();
        }
    }
}
