using NotificationChannelParser.Core;

namespace NotificationChannelParser
{
    public static class NotificationChannelParser
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write(
                    "Enter the notification title with tags ([BE], [FE], [QA], [Urgent] or type 'exit' to quit): "
                );
                var notificationTitle = Console.ReadLine();

                if (string.Equals(notificationTitle, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var notificationChannels = ChannelParser.GetNotificationChannels(notificationTitle);

                Console.WriteLine(notificationChannels.Count > 0
                    ? $"Receive channels: {string.Join(", ", notificationChannels)}"
                    : "No valid channels found.");
                Console.WriteLine();
            }
        }
    }
}
