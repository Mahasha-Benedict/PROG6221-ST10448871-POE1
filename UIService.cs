using System;
using System.Threading;

namespace CybersecurityChatbot
{

    /// Shows the console manipulation and visual enhancements
    public class UIService
    {
        private readonly Random random = new Random();

        /// Displays ASCII art logo (Question 2)

        public void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiArt = @"
    ╔══════════════════════════════════════════════════════════════════╗
    ║                                                                  ║
    ║      ██████╗██╗   ██╗██████╗ ███████╗██████╗                     ║
    ║     ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗                    ║
    ║     ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝                    ║
    ║     ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗                    ║
    ║     ╚██████╗   ██║   ██████╔╝███████╗██║  ██║                    ║
    ║      ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝                    ║
    ║                                                                  ║
    ║     █████╗ ██╗    ██╗ █████╗ ██████╗ ███████╗███╗   ██╗███████╗  ║
    ║    ██╔══██╗██║    ██║██╔══██╗██╔══██╗██╔════╝████╗  ██║██╔════╝  ║
    ║    ███████║██║ █╗ ██║███████║██████╔╝█████╗  ██╔██╗ ██║███████╗  ║
    ║    ██╔══██║██║███╗██║██╔══██║██╔══██╗██╔══╝  ██║╚██╗██║╚════██║  ║
    ║    ██║  ██║╚███╔███╔╝██║  ██║██║  ██║███████╗██║ ╚████║███████║  ║
    ║    ╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝╚══════╝  ║
    ║                                                                  ║
    ║            South African Cybersecurity Awareness Bot             ║
    ╚══════════════════════════════════════════════════════════════════╝";

            Console.WriteLine(asciiArt);
            Console.ResetColor();
            Console.WriteLine();

            Thread.Sleep(500);
        }


        /// Displays welcome message with decorative borders

        public void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    WELCOME TO CYBERSECURITY                      ║");
            Console.WriteLine("║                   AWARENESS ASSISTANT BOT                        ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        /// Displays a personalized greeting for the user

        public void DisplayPersonalizedGreeting(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║  Hello, {userName}!                                              ║");
            Console.WriteLine($"║  I'm your Cybersecurity Awareness Assistant.                     ║");
            Console.WriteLine($"║  I'm here to help you stay safe online!                          ║");
            Console.WriteLine($"╚══════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }


        /// Displays all available topics the user can ask about

        public void ShowAvailableTopics()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║   TOPICS I CAN HELP YOU WITH                                                       ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║                                                                                   ║");
            Console.WriteLine("║   Password Safety          - Creating and managing strong passwords               ║");
            Console.WriteLine("║   Phishing Emails          - Spotting fake emails and messages                    ║");
            Console.WriteLine("║   Safe Browsing            - Avoiding dangerous websites and downloads            ║");
            Console.WriteLine("║   Social Engineering      - Recognizing manipulation attempts                     ║");
            Console.WriteLine("║   Malware Protection       - Keeping your devices clean                           ║");
            Console.WriteLine("║   Two-Factor Authentication - Adding extra security layers                        ║");
            Console.WriteLine("║                                                                                   ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║     SAMPLE QUESTIONS:                                                                ║");
            Console.WriteLine("║     • 'How are you?'                                                                 ║");
            Console.WriteLine("║     • 'What's your purpose?'                                                         ║");
            Console.WriteLine("║     • 'What can I ask you about?'                                                    ║");
            Console.WriteLine("║     • 'How do I create a strong password?'                                           ║");
            Console.WriteLine("║     • 'What is phishing?'                                                            ║");
            Console.WriteLine("║     • 'How do I spot a scam?'                                                        ║");
            Console.WriteLine("║                                                                                      ║");
            Console.WriteLine("║     Type 'exit' or 'quit' when you're done                                           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }


        public void ShowInputPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n You: ");
            Console.ResetColor();
        }

        /// Displays bot response with formatting

        public void DisplayBotResponse(string response)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bot: ");
            Console.ResetColor();

            Console.WriteLine(response);
        }


        /// Displays an error message with red 

        public void DisplayErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {message}");
            Console.ResetColor();
        }

        /// Displays goodbye message when exiting

        public void DisplayGoodbyeMessage(string? userName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║  Thank you for using the Cybersecurity Awareness Bot, {userName}!                    ║");
            Console.WriteLine("║                                                                                      ║");
            Console.WriteLine("║     REMEMBER:                                                                        ║");
            Console.WriteLine("║     - Always think before you click                                                  ║");
            Console.WriteLine("║     - Keep your passwords strong and unique                                          ║");
            Console.WriteLine("║     - Enable two-factor authentication where possible                                ║");
            Console.WriteLine("║     - Stay informed about new cyber threats                                          ║");
            Console.WriteLine("║                                                                                      ║");
            Console.WriteLine("║   Stay safe online, South Africa!                                   	              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
        }


        /// Simulates a real-time typing effect for more realistic conversation
        public void SimulateTyping()
        {
            Console.Write("Bot is typing");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }
            Console.WriteLine();
            Thread.Sleep(200);
        }
        public void ShowHelpReminder()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Tip: Type 'exit' or 'quit' to end the conversation");
            Console.WriteLine("   Type 'help' to see available topics again");
            Console.ResetColor();
        }

        /// Displays section divider

        public void DisplayDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.ResetColor();
        }
    }
}