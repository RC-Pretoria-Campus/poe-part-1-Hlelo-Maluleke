using Jarv1s;
using System;
using System.Reflection.Metadata;

wavPlayer wavPlayer = new wavPlayer();
wavPlayer.PlayWav("GreetingVoice.wav");
ASCII ascii = new ASCII(); //an instance of the ASCII class 
ascii.DisplayASCIIART(); //to call the DisplayASCIIART method

Console.ForegroundColor = ConsoleColor.Green;
ResponseSys.TypingEffect("Hello. Please enter your name: ");
Console.ResetColor();

// Loop to ensure the user enters a valid name (not null or whitespace)
string userName = null;
while (string.IsNullOrWhiteSpace(userName))
{
    userName = Console.ReadLine().ToUpper();

    if (userName == null || string.IsNullOrWhiteSpace(userName))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        ResponseSys.TypingEffect("Invalid input. Please enter a valid name.");
        Console.ResetColor();
    }
}

Console.ForegroundColor = ConsoleColor.Green;
ResponseSys.TypingEffect($"Welcome to Jarv1s, {userName}! How can I assist you today? Type 'help' for options or 'exit' to end the chat.");
Console.ResetColor();

// Main loop to continuously read user input and respond until the user types "exit"
while (true)
{
    ResponseSys response = new ResponseSys();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"{userName}: ");
    string userInput = Console.ReadLine().ToLower();
    string printResponse = response.UserResponse(userInput);
    if (printResponse == "exit")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        ResponseSys.TypingEffect("Exiting Jarv1s. Goodbye!");
        Console.ResetColor();
        break;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    ResponseSys.TypingEffect(printResponse, 20);
    Console.ResetColor();
}