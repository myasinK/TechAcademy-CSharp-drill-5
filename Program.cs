using System;

namespace BooleanLogicIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16( Console.ReadLine() );
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qualified?");
            Console.WriteLine( (age > 15) && ( dui == false ) && ( tickets <= 3 ) );
            Console.ReadLine();
        }
    }
}
