using NotificationChannelParser.Core;

namespace NotificationChannelParser
{
    public static class NotificationChannelParser
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Enter the notification title: ");
                var input = Console.ReadLine();
                
                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var channels = ChannelParser.GetNotificationChannels(input);
                
                Console.WriteLine(channels.Count > 0
                    ? $"Receive channels: {string.Join(", ", channels)}"
                    : "No valid channels found.");
                Console.WriteLine();
            }
        }
    }
}