using System;
using System.IO;
using System.Media;

namespace CybersecurityChatbot
{
    public class VoiceService
    {
        public void PlayGreeting()
        {
            try
            {
                // Get the path where the application is running
                string appPath = AppDomain.CurrentDomain.BaseDirectory;
                string audioPath = Path.Combine(appPath, "greeting.wav");

                // Check if file exists
                if (!File.Exists(audioPath))
                {
                    Console.WriteLine($"[Audio] File not found at: {audioPath}");
                    return;
                }

                // Play the audio
                using (SoundPlayer player = new SoundPlayer(audioPath))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Audio] Error: {ex.Message}");
            }
        }
    }
}