using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityChatbot
{
    /// <summary>
    /// Handles generating intelligent responses based on user input
    /// Demonstrates dictionaries, pattern matching, and response logic
    /// </summary>
    public class ResponseHandler
    {
        private readonly Dictionary<string, Func<string, string>> responsePatterns;
        private int interactionCount;

        public ResponseHandler()
        {
            interactionCount = 0;
            responsePatterns = new Dictionary<string, Func<string, string>>(StringComparer.OrdinalIgnoreCase)
            {
                { "how are you", (name) => GetHowAreYouResponse() },
                { "purpose", (name) => GetPurposeResponse() },
                { "what can i ask", (name) => GetAvailableTopicsResponse() },
                { "what can you do", (name) => GetAvailableTopicsResponse() },
                { "password", (name) => GetPasswordAdvice(name) },
                { "phish", (name) => GetPhishingAdvice(name) },
                { "brows", (name) => GetSafeBrowsingAdvice(name) },
                { "social engineering", (name) => GetSocialEngineeringAdvice(name) },
                { "malware", (name) => GetMalwareAdvice(name) },
                { "virus", (name) => GetMalwareAdvice(name) },
                { "ransomware", (name) => GetMalwareAdvice(name) },
                { "2fa", (name) => GetTwoFactorAuthAdvice(name) },
                { "two factor", (name) => GetTwoFactorAuthAdvice(name) },
                { "safe browsing", (name) => GetSafeBrowsingAdvice(name) },
                { "secure", (name) => GetPasswordAdvice(name) },
                { "protect", (name) => GetProtectionAdvice(name) },
                { "scam", (name) => GetPhishingAdvice(name) },
                { "click", (name) => GetPhishingAdvice(name) },
                { "link", (name) => GetPhishingAdvice(name) },
                { "email", (name) => GetPhishingAdvice(name) }
            };
        }

        public int GetInteractionCount() => interactionCount;

        /// <summary>
        /// Main method to get appropriate response for user input
        /// </summary>
        public string GetResponse(string input, string? userName)
        {
            interactionCount++;

            // Check for greetings
            if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey") || input == "good morning" || input == "good afternoon")
            {
                return GetGreetingResponse(userName);
            }

            // Check for thank you
            if (input.Contains("thank") || input.Contains("thanks") || input.Contains("appreciate"))
            {
                return GetThankYouResponse(userName);
            }

            // Check for goodbyes (handled in main loop but include for direct responses)
            if (input.Contains("bye") || input.Contains("goodbye") || input == "see you")
            {
                return GetGoodbyeResponse(userName);
            }

            // Check each pattern
            foreach (var pattern in responsePatterns)
            {
                if (input.Contains(pattern.Key, StringComparison.OrdinalIgnoreCase))
                {
                    return pattern.Value(userName ?? "friend");
                }
            }

            // Default response for unrecognized input (Question 5)
            return GetDefaultResponse();
        }

        private string GetGreetingResponse(string? name)
        {
            string[] greetings = {
                $"Hello {name}! How can I help you with cybersecurity today?",
                $"Hi there {name}! Ready to learn about staying safe online?",
                $"Greetings {name}! What would you like to know about cybersecurity?",
                $"Welcome back {name}! What cybersecurity topic shall we explore today?"
            };
            return greetings[new Random().Next(greetings.Length)];
        }

        private string GetHowAreYouResponse()
        {
            string[] responses = {
                "I'm functioning well and ready to help! How can I assist you with cybersecurity today?",
                "Operating at full capacity! I'm here to protect and educate. What would you like to know?",
                "I'm doing great! Cybersecurity awareness is my passion. What can I help you with?",
                "All systems go! Ask me anything about staying safe online!"
            };
            return responses[new Random().Next(responses.Length)];
        }

        private string GetPurposeResponse()
        {
            return " My purpose is to educate South Africans about cybersecurity threats and help them stay safe online. I'm part of a national campaign to combat cybercrime and protect citizens from digital threats. Together, we can build a safer digital South Africa! 🇿🇦";
        }

        private string GetAvailableTopicsResponse()
        {
            return " I can help you with these cybersecurity topics:\n\n" +
                   " **Password Safety** - How to create and manage strong passwords\n" +
                   " **Phishing Detection** - Identifying fake emails and messages\n" +
                   " **Safe Browsing** - Avoiding dangerous websites and downloads\n" +
                   " **Social Engineering** - Recognizing manipulation attempts\n" +
                   " **Malware Protection** - Keeping your devices clean\n" +
                   " **Two-Factor Authentication** - Adding extra security layers\n\n" +
                   " Just ask me about any of these topics! For example: 'How do I create a strong password?' or 'What is phishing?'";
        }

        private string GetPasswordAdvice(string name)
        {
            return $"Great question {name}! Here are essential password safety tips 🔐:\n\n" +
                   " **Length matters**: Use passwords at least 12-16 characters long\n" +
                   " **Mix it up**: Combine uppercase, lowercase, numbers, and symbols\n" +
                   " **Avoid personal info**: Never use birthdays, names, or common words\n" +
                   " **Unique passwords**: Different password for each account\n" +
                   " **Password managers**: Use tools like Bitwarden or LastPass\n" +
                   " **Two-factor authentication**: Enable 2FA whenever possible\n\n" +
                   " **Did you know?** A 12-character password with mixed characters would take centuries to crack!";
        }

        private string GetPhishingAdvice(string name)
        {
            return $"{name}, phishing is when criminals trick you into revealing personal info. Here's how to spot them 🎣:\n\n" +
                   "	 **Red Flags to Watch:**\n" +
                   "   • Suspicious sender email addresses\n" +
                   "   • Urgent or threatening language ('Act now!', 'Your account will be closed')\n" +
                   "   • Spelling and grammar mistakes\n" +
                   "   • Unexpected attachments or links\n" +
                   "   • Requests for personal information\n\n" +
                   "	 **What to do:**\n" +
                   "   • Never click suspicious links\n" +
                   "   • Hover over links to see the real URL\n" +
                   "   • Verify with the organization directly\n" +
                   "   • Report phishing attempts to [report@cybersecurity.gov.za](mailto:report@cybersecurity.gov.za)";
        }

        private string GetSafeBrowsingAdvice(string name)
        {
            return $"Safe browsing tips for you {name} :\n\n" +
                   "	 **Look for security indicators:**\n" +
                   "   • 'https://' and padlock icon in address bar\n" +
                   "   • Website security certificates\n\n" +
                   "	 **Be cautious with links:**\n" +
                   "   • Avoid shortened URLs (like bit.ly) from unknown sources\n" +
                   "   • Hover before you click\n\n" +
                   "	 **Stay updated:**\n" +
                   "   • Keep browser and extensions updated\n" +
                   "   • Use ad-blockers to avoid malicious ads\n" +
                   "   • Clear browsing data regularly\n\n" +
                   "	 **Smart downloads:**\n" +
                   "   • Download only from official sources\n" +
                   "   • Scan files with antivirus before opening";
        }

        private string GetSocialEngineeringAdvice(string name)
        {
            return $"{name}, social engineering manipulates people into revealing information. Watch out for 👤:\n\n" +
                   " 	**Common Tactics:**\n" +
                   "   • Unsolicited calls asking for personal details\n" +
                   "   • 'Too good to be true' offers\n" +
                   "   • People pretending to be IT support\n" +
                   "   • Requests to verify account details\n" +
                   "   • Creating urgency or fear\n\n" +
                   " 	**Protect Yourself:**\n" +
                   "   • Never share passwords or OTPs\n" +
                   "   • Verify identity through official channels\n" +
                   "   • Hang up and call back using official numbers\n" +
                   "   • Trust your instincts - if it feels wrong, it probably is!";
        }

        private string GetMalwareAdvice(string name)
        {
            return $"Protect yourself from malware, {name} :\n\n" +
                   "	 **Prevention:**\n" +
                   "   • Keep operating system updated\n" +
                   "   • Use reputable antivirus software\n" +
                   "   • Don't open attachments from unknown senders\n" +
                   "   • Download only from official sources\n\n" +
                   "	 **Warning Signs:**\n" +
                   "   • Computer running slowly\n" +
                   "   • Pop-ups appearing frequently\n" +
                   "   • Files being encrypted or disappearing\n" +
                   "   • Browser redirects to unknown sites\n\n" +
                   "	 **If Infected:**\n" +
                   "   • Disconnect from internet\n" +
                   "   • Run antivirus scan\n" +
                   "   • Restore from backup\n" +
                   "   • Seek professional help";
        }

        private string GetTwoFactorAuthAdvice(string name)
        {
            return $"{name}, Two-Factor Authentication (2FA) adds an extra security layer :\n\n" +
                   "	 **Why use 2FA?**\n" +
                   "   • Even if someone steals your password, they can't access your account\n" +
                   "   • Reduces account takeover risk by 99.9%\n\n" +
                   " 	**Types of 2FA:**\n" +
                   "   • SMS codes (least secure but better than nothing)\n" +
                   "   • Authenticator apps (Google Authenticator, Microsoft Authenticator)\n" +
                   "   • Hardware keys (YubiKey) - most secure\n\n" +
                   " 	**Enable 2FA on:**\n" +
                   "   • Email accounts\n" +
                   "   • Banking apps\n" +
                   "   • Social media\n" +
                   "   • Any account with sensitive information";
        }

        private string GetProtectionAdvice(string name)
        {
            return $"{name}, here's a comprehensive protection strategy :\n\n" +
                   "- **Strong Passwords + 2FA**\n" +
                   "- **Keep Software Updated**\n" +
                   "- **Use Antivirus Software**\n" +
                   "- **Backup Important Data**\n" +
                   "- **Think Before Clicking**\n" +
                   "- **Secure Your Wi-Fi**\n" +
                   "- **Monitor Account Activity**\n" +
                   "- **Educate Yourself Continuously**\n\n" +
                   "Remember: Cybersecurity is a journey, not a destination!";
        }

        private string GetThankYouResponse(string? name)
        {
            string[] responses = {
                $"You're welcome {name}! Stay safe online! ",
                $"My pleasure {name}! Remember, cybersecurity is everyone's responsibility in South Africa 🇿🇦",
                $"Happy to help {name}! Let me know if you have more questions about staying safe online.",
                $"Anytime {name}! Knowledge is power when it comes to cybersecurity "
            };
            return responses[new Random().Next(responses.Length)];
        }

        private string GetGoodbyeResponse(string? name)
        {
            string[] responses = {
                $"Stay safe out there {name}! Remember to always think before you click ",
                $"Until next time {name}! Keep those passwords strong and stay vigilant ",
                $"Goodbye {name}! Visit again to learn more about cybersecurity "
            };
            return responses[new Random().Next(responses.Length)];
        }

        private string GetDefaultResponse()
        {
            string[] defaultResponses = {
                "I didn't quite understand that. Could you rephrase? Try asking about passwords, phishing, or safe browsing.",
                "Hmm, I'm not sure about that. Would you like to learn about cybersecurity topics instead?",
                "I'm still learning! Could you ask me about password safety, phishing, or online security?",
                "That's outside my knowledge area. I specialize in cybersecurity awareness. What would you like to know?",
                "I'm here to help with cybersecurity! Try asking: 'What is phishing?' or 'How do I create a strong password?' "
            };
            return defaultResponses[new Random().Next(defaultResponses.Length)];
        }
    }
}