using System.Text.RegularExpressions;

namespace NotificationChannelParser.Utilities
{
    internal static partial class RegexPatterns
    {
        [GeneratedRegex(@"\[(.*?)\]", RegexOptions.Compiled)]
        internal static partial Regex TagRegex();
    }
}
