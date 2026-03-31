using System;

namespace CybersecurityChatbot
{
    /// <summary>
    /// Main chatbot class
    /// </summary>
    public class Chatbot
    {
        private string? userName;
        private readonly VoiceService voiceService;
        private readonly UIService uiService;
        private readonly ResponseHandler responseHandler;
        private bool isRunning;

        public Chatbot()
        {
            voiceService = new VoiceService();
            uiService = new UIService();
            responseHandler = new ResponseHandler();
            isRunning = true;
        }

        public void Start()
        {
            try
            {
                // Play voice greeting if available
                voiceService.PlayGreeting();

                // Display ASCII art
                uiService.DisplayAsciiArt();

                // Get user name
                uiService.DisplayWelcomeMessage();
                userName = GetUserName();

                // Personalize greeting
                uiService.DisplayPersonalizedGreeting(userName);

                // Show available topics
                uiService.ShowAvailableTopics();

                // Main conversation loop
                RunConversationLoop();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private string GetUserName()
        {
            while (true)
            {
                Console.Write("Please enter your name: ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Please enter a valid name.");
            }
        }

        private void RunConversationLoop()
        {
            while (isRunning)
            {
                Console.Write("\nYou: ");
                string? userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Bot: I didn't understand. Could you rephrase?");
                    continue;
                }

                string input = userInput.ToLower().Trim();

                // Check for exit
                if (input == "exit" || input == "quit" || input == "bye")
                {
                    isRunning = false;
                    uiService.DisplayGoodbyeMessage(userName);
                    continue;
                }

                // Get response
                string response = responseHandler.GetResponse(input, userName);
                Console.WriteLine($"Bot: {response}");
            }
        }
    }
}
