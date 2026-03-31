using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.WindowWidth = 100;

            var chatbot = new Chatbot();
            chatbot.Start();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}