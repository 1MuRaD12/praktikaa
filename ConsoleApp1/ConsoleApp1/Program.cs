using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drug drug = new Drug();
            Console.WriteLine("name:");
            drug.Name = Console.ReadLine();

            drug.Count = 20;
            drug.price = 5.6;
        }
    }
}
