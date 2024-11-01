using NotificationChannelParser.Utilities;

namespace NotificationChannelParser.Core
{
    internal static class ChannelParser
    {
        internal static List<string> GetNotificationChannels(string? notificationTitle)
        {
            if (string.IsNullOrWhiteSpace(notificationTitle)) return new List<string>();

            var tagMatches = RegexPatterns.TagRegex().Matches(notificationTitle);

            return tagMatches
                .Select(match => match.Groups[1].Value)
                .Where(tag => NotificationChannels.ValidChannels.Contains(tag))
                .Distinct()
                .ToList();
        }
    }
}
