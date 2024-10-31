using System.Text.RegularExpressions;

namespace NotificationChannelParser;

public static partial class ChannelParser
{
    private static readonly HashSet<string> ValidChannels = ["BE", "FE", "QA", "Urgent"];
    
    public static List<string> GetNotificationChannels(string? input)
    {
        if (string.IsNullOrWhiteSpace(input)) return [];
        
        var matches = TagRegex().Matches(input);

        return matches
            .Select(match => match.Groups[1].Value)
            .Where(tag => ValidChannels.Contains(tag))
            .Distinct()
            .ToList();
    }

    [GeneratedRegex(@"\[(.*?)\]")]
    private static partial Regex TagRegex();
}