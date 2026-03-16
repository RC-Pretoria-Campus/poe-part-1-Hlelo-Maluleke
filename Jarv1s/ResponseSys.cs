using System;
using System.Collections.Generic;
using System.Text;

namespace Jarv1s
{
    public class ResponseSys
    {
        private Dictionary<string, string> responses = new Dictionary<string, string>
        {
            { "hello", "Hello! How can I assist you today?" },
            { "hi", "Hello! How can I assist you today?" },
            { "hey", "Hello! How can I assist you today?" },
            { "purpose", "To provide educational informaion about cybersecurity." },
            { "help", "Use keywords such as, purpose, can, help, exit." },
            { "what can", "Type help to see my available capabilities." },
            { "threat", "There are different types of threats such ad: DDos, Spoofing, Phising,..." },
            { "thanks", "You're welcome! If you have any more questions, feel free to ask." }
        };

        public string UserResponse(string userInput)
        {
            userInput = userInput.ToLower();
            foreach (var response in responses)
            {
                if (userInput.Contains(response.Key) || userInput.ToLower() == "exit")
                {
                    return response.Value;
                }
            }
            return "I'm sorry, I don't understand. Can you please rephrase?";
        }
    }
}

