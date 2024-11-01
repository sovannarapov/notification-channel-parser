using NotificationChannelParser.Utilities;

namespace NotificationChannelParser.Core
{
    internal static class ChannelParser
    {
        internal static List<string> GetNotificationChannels(NotificationTitle notificationTitle)
        {
            if (string.IsNullOrWhiteSpace(notificationTitle.Title)) return [];

            var tagMatches = RegexPatterns.TagRegex().Matches(notificationTitle.Title);

            return tagMatches
                .Select(match => match.Groups[1].Value)
                .Where(tag => NotificationChannels.ValidChannels.Contains(tag))
                .Distinct()
                .ToList();
        }
    }
}
