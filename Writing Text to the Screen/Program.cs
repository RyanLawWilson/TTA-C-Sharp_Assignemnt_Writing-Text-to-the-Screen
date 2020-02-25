using System;

namespace Writing_Text_to_the_Screen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Acme Accounting Systems");
            System.Threading.Thread.Sleep(1000);
            Console.Write("Remember, ");
            System.Threading.Thread.Sleep(500);
            Console.Write("We're ");

            int characterDelay = 100;
            //The word "accounting" but it is typed out slowly.  Can be refactored into a method
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("\"a");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("c");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("c");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("o");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("u");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("n");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("t");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("i");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("n");
            System.Threading.Thread.Sleep(characterDelay);
            Console.Write("g\"");

            System.Threading.Thread.Sleep(500);
            Console.Write(" on you!");

            Console.Read();
        }
    }
}
