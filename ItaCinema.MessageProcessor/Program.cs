using ItaCinema.Core.Consumers;
using Microsoft.Extensions.DependencyInjection;

namespace ItaCinema.MessageProcessor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://itacinemastaging.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=Kesd97aHDX+mbqwXLsOWcLM92axn2T+3hHXxV7L2N6I=";
            var messageReceiver = new MessageReceiver(connectionString);
            messageReceiver.Receive();
        }
    }
}
