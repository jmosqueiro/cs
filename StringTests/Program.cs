using System;

namespace StringTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "test";
            string msg = name + " is done";

            System.Console.WriteLine(msg);
            
            string toUpperMsg = msg.ToUpper();
            System.Console.WriteLine(toUpperMsg);
            Console.ReadLine();
            
        }
    }
}
