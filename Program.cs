using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CybersecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASCII Art Logo for "Cybersecurity Awareness Bot"
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
    .--------.
   / .------. \         [ SAFE ]
  | /        \ |     
  ||          ||         SECURE_
  | \________/ |     ==============
  .------------.     
  | [======]   |    ""Guard your data,
  |   .----.   |     secure your future.""
  |   | () |   |     
  |   '----'   |     
  '------------'   Cybersecurity Awareness Bot     
            ");
            Console.ResetColor();
            Console.WriteLine("======================================="); int headerLineLength = 80; int logoWidth = 82;
            // Play recorded voice greeting (place greeting.wav in output directory)
            try
            {
                using (var player = new SoundPlayer("\"C:\\Users\\mziny\\Music\\WhatsApp Audio 2026-06-02 at 4.38.26 AM.mpeg\""))
                {
                    player.PlaySync(); // Synchronous play to hear before proceeding [web:73][web:74]
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("(Greeting audio not found: " + ex.Message + ". Continuing...)");
            }

            // Get user name
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Hello! Welcome to the CyberSecurity Awareness Chatbot. What is your name?: ");
            string userName = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                userName = "User";
            }

            Console.WriteLine($"\nHi {userName}! Welcome to the Cybersecurity Awareness Bot.");

            // Chat loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"\n{userName}, Ask me anything (type 'exit' to quit): ");
                string input = Console.ReadLine()?.Trim().ToLower();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a question, or type 'exit'.");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine($"Goodbye {userName}! Do not forget to stay safe online!");
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
                return $"I'm a chatbot, I do not have feelings {userName}! Ready to help with cybersecurity awareness tips.";
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
                return $"{userName},A strong password should be at least 8-12 characters long and include a mix of uppercase letters, lowercase letters, numbers, and special characters. ";
            }
            else if (input.Contains("phish") || input.Contains("phishing"))
            {
                return $"{userName}, Phishing is a form of social engineering in which cybercriminals use deceptive messages, emails, text messages, phone calls, or fake websites to manipulate victims into sharing personal data such as passwords, credit card numbers, or banking information, or to perform actions that compromise security.";
            }
            else if (input.Contains("brows") || input.Contains("browsing") || input.Contains("safe browsing"))
            {
                return $"{userName}, Safe browsing refers to the combination of tools, practices, and behaviors that help users avoid online threats such as malware, phishing, spyware, ransomware, and malicious websites.";
            }
            else
            {
                return $"{userName}, that's not a supported topic yet. Try password safety, phishing, safe browsing, 'how are you?', 'purpose', or 'what can I ask?'";
            }
        }
    }
}