using System;
using System.Reflection.Metadata;

namespace Jarv1s
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCII ascii = new ASCII(); //an instance of the ASCII class 
            ascii.DisplayASCIIART(); //to call the DisplayASCIIART method

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello, User!");
                Console.ResetColor();

                ResponseSys response = new ResponseSys();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("User: ");
                string userInput = Console.ReadLine().ToLower();
                string printResponse = response.UserResponse(userInput);
                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting Jarv1s. Goodbye!");
                    Console.ResetColor();
                    break;
                }
                Console.WriteLine(printResponse);
                Console.ResetColor();
            }
            



        }
    }
}
