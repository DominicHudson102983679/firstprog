using System;

namespace firstprog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your firstname");
            string firstname = Console.ReadLine();

            Console.WriteLine("Whats your surname");
            string surname = Console.ReadLine();

            Console.WriteLine(firstname);
            Console.WriteLine(surname);
        }
    }
}
