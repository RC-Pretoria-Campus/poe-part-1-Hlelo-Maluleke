using Jarv1s;
using System;
using System.Reflection.Metadata;
using System.Speech.Synthesis;

/* PSEUDOCODE 
 - Display ASCII art using ASCII class.
 - Prompt user for name.
 - Use a nullable string variable (userName = null) to hold name input while validating.
 - Loop until a non-empty, non-whitespace name is entered:
    - Read a line from Console and call .ToUpper() to normalize, then store in userName.
    - If userName is null or whitespace, show an error and continue the loop.
    - When valid name is entered, exit the loop.
 - Greet the user with the validated userName.
 - Enter the main chat loop:
    - Display colored prompt with the username.
    - Read user input from Console and convert to lowercase.
    - Get response from ResponseSys.UserResponse() method.
    - Check if user typed "exit" to break out of loop.
    - Display response using ResponseSys.PrintWithTypingEffect() for typewriter effect.
    - Reset console color and repeat until user exits.
*/
SpeechSynthesizer speech = new SpeechSynthesizer();
speech.Speak("I am a CyberSecurity awareness chatbot, welcome, please enter your name.");
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
    if (userInput == "exit")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        ResponseSys.TypingEffect("Exiting Jarv1s. Goodbye!");
        Console.ResetColor();
        break;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    ResponseSys.TypingEffect(printResponse, 30);
    Console.ResetColor();
}