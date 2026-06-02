using CyberSecurityAwarenessBotGUI.Models;

namespace CyberSecurityAwarenessBotGUI.Services
{
    public class MemoryService
    {
        private readonly UserProfile _userProfile;

        public MemoryService(UserProfile userProfile)
        {
            _userProfile = userProfile;
        }

        public void RememberName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                _userProfile.Name = name.Trim();
            }
        }

        public void RememberFavouriteTopic(string topic)
        {
            if (!string.IsNullOrWhiteSpace(topic))
            {
                _userProfile.FavouriteTopic = topic.Trim();
            }
        }

        public void RememberLastTopic(string topic)
        {
            if (!string.IsNullOrWhiteSpace(topic))
            {
                _userProfile.LastTopic = topic.Trim();
            }
        }

        public string GetUserName()
        {
            return _userProfile.Name;
        }

        public string GetFavouriteTopic()
        {
            return _userProfile.FavouriteTopic;
        }

        public string GetLastTopic()
        {
            return _userProfile.LastTopic;
        }
    }
}
