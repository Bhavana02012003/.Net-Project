using System;

namespace MyDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🔒 Hello Welcome, Secure .NET World!");
            
            string userInput = Console.ReadLine(); // 🛑 Potential security issue (SecurityCodeScan will flag this)
            Console.WriteLine("User input: " + userInput);
        }
    }
}
