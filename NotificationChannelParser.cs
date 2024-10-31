using NotificationChannelParser.Core;

namespace NotificationChannelParser
{
    public static class NotificationChannelParser
    {
        public static void Main()
        {
            Console.Write("Enter the notification title: ");
            var input = Console.ReadLine();

            var channels = ChannelParser.GetNotificationChannels(input);
            Console.WriteLine(channels.Count > 0
                ? $"Receive channels: {string.Join(", ", channels)}"
                : "No valid channels found.");
        }
    }
}