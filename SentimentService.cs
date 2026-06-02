namespace CyberSecurityAwarenessBotGUI.Services
{
    public class SentimentService
    {
        public string DetectSentiment(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") || input.Contains("scared") || input.Contains("afraid"))
            {
                return "worried";
            }

            if (input.Contains("confused") || input.Contains("unsure") || input.Contains("don't understand"))
            {
                return "confused";
            }

            if (input.Contains("frustrated") || input.Contains("angry") || input.Contains("annoyed"))
            {
                return "frustrated";
            }

            if (input.Contains("curious") || input.Contains("interested"))
            {
                return "curious";
            }

            return "neutral";
        }

        public string GetSentimentPrefix(string sentiment)
        {
            switch (sentiment)
            {
                case "worried":
                    return "It is understandable to feel worried. Cyber threats can be stressful, but learning simple safety steps can help you stay protected. ";

                case "confused":
                    return "No problem. I will explain it in a simple way. ";

                case "frustrated":
                    return "I understand that cybersecurity can feel frustrating sometimes. Let us take it step by step. ";

                case "curious":
                    return "That is a good topic to explore. Curiosity helps you become more aware online. ";

                default:
                    return string.Empty;
            }
        }
    }
}