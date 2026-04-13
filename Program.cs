using System;
using System.Media;

namespace CybersecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASCII Art Logo for "Cybersecurity Awareness Bot"
            Console.WriteLine(@"
   _____                      _            
  / ____|                    | |           
 | |  __  ___  _   _  __ _  | |__    ___  
 | | |_ |/ _ \| | | |/ _` | | '_ \  / __| 
 | |__| | (_) | |_| | (_| | | | | || (__  
  \_____|\___/ \__, |\__,_| |_| |_| \___| 
               __/ |                      
              |___/     Cybersecurity Awareness Bot     
            ");
            Console.WriteLine("======================================="); int headerLineLength = 78; int logoWidth = 82;
            // Play recorded voice greeting (place greeting.wav in output directory)
            try
            {
                using (var player = new SoundPlayer("greeting.wav"))
                {
                    player.PlaySync(); // Synchronous play to hear before proceeding [web:73][web:74]
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("(Greeting audio not found: " + ex.Message + ". Continuing...)");
            }

            // Get user name
            Console.Write("Hello! What's your name? ");
            string userName = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                userName = "User";
            }

            Console.WriteLine($"\nHi {userName}! Welcome to the Cybersecurity Awareness Bot.[web:70]");

            // Chat loop
            while (true)
            {
                Console.Write($"\n{userName}, ask me about cybersecurity (or 'exit'): ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a question, or type 'exit'.");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine($"Goodbye {userName}! Stay safe online.");
                    break;
                }

                string response = GetResponse(input, userName);
                Console.WriteLine($"Bot: {response}");
            }
        }

        static string GetResponse(string input, string userName)
        {
            if (input.Contains("how are you"))
            {
                return $"I'm great, {userName}! Ready to help with cybersecurity tips.";
            }
            else if (input.Contains("purpose") || input.Contains("what's your purpose"))
            {
                return $"My purpose, {userName}, is to raise awareness on cyber threats like phishing and safe habits to protect you online.";
            }
            else if (input.Contains("what can i ask") || input.Contains("topics"))
            {
                return $"{userName}, ask about password safety, phishing, safe browsing, or basics like 'how are you?'";
            }
            else if (input.Contains("password") || input.Contains("passwords"))
            {
                return $"{userName}, for password safety: Use unique, strong passphrases (e.g., CoffeeTreeHouse#91) with uppercase, lowercase, numbers, symbols. Avoid writing them down, reuse, or simple ones like '123456'. Enable MFA everywhere. Use a password manager.[web:88]";
            }
            else if (input.Contains("phish") || input.Contains("phishing"))
            {
                return $"{userName}, phishing tricks you via fake emails/links to steal info. Check sender, hover links (don't click), look for HTTPS. In SA, phishing causes 52% of incidents—verify before acting![web:79][cite:72]";
            }
            else if (input.Contains("brows") || input.Contains("browsing") || input.Contains("safe browsing"))
            {
                return $"{userName}, safe browsing: Stick to HTTPS sites, use ad-blockers, update browser/OS. Avoid suspicious downloads/links. Enable click-to-play for plugins.";
            }
            else
            {
                return $"{userName}, that's not a supported topic yet. Try password safety, phishing, safe browsing, 'how are you?', 'purpose', or 'what can I ask?'";
            }
        }
    }
}