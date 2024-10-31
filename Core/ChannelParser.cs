using NotificationChannelParser.Utilities;

namespace NotificationChannelParser.Core
{
    internal static class ChannelParser
    {
        internal static List<string> GetNotificationChannels(string? input)
        {
            if (string.IsNullOrWhiteSpace(input)) return [];

            var matches = RegexPatterns.TagRegex().Matches(input);

            return matches
                .Select(match => match.Groups[1].Value)
                .Where(tag => NotificationChannels.ValidChannels.Contains(tag))
                .Distinct()
                .ToList();
        }
    }
}