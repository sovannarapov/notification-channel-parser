using System.Text.RegularExpressions;

namespace NotificationChannelParser.Utilities
{
    internal static partial class RegexPatterns
    {
        [GeneratedRegex(@"\[(.*?)\]")]
        internal static partial Regex TagRegex();
    }
}
