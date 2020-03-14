using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DarkRoast beverage = new DarkRoast();

            Console.WriteLine(beverage.Cost());
            Console.ReadLine();
        }
    }
}
