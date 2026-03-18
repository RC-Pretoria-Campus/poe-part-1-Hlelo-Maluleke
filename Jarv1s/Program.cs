using Jarv1s;
using System;
using System.Reflection.Metadata;

ASCII ascii = new ASCII(); //an instance of the ASCII class 
ascii.DisplayASCIIART(); //to call the DisplayASCIIART method

UserIntro userIntro = new UserIntro(); //an instance of the UserIntro class
userIntro.GetUserName(); //to call the GetUserName method

string userName = null;
while (string.IsNullOrWhiteSpace(userName))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Hello. Please enter your name: ");
    Console.ResetColor();
    userName = Console.ReadLine().ToUpper();

    if (userName == null || string.IsNullOrWhiteSpace(userName))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter a valid name.");
        Console.ResetColor();
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Welcome to Jarv1s, {userName}! How can I assist you today? Type 'help' for options.");
Console.ResetColor();

while (true)
{
    ResponseSys response = new ResponseSys();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"{userName}: ");
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