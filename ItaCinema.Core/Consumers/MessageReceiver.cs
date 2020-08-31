using ItaCinema.Core.Consumers.Interfaces;
using ItaCinema.Domain.Models;
using ItaCinema.SDK.Consumers;
using Microsoft.Azure.ServiceBus;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ItaCinema.Core.Consumers
{
    public class MessageReceiver : IMessageReceiver
    {
        private readonly string _connectionString;

        private const string MovieQueueName = "movie";

        public MessageReceiver(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task Receive()
        {
            var client = new QueueClient(_connectionString, MovieQueueName);
            var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            };

            Movie movie = null;

            client.RegisterMessageHandler(async (message, token) =>
            {
                movie = Serializer.Deserialize<Movie>(Encoding.UTF8.GetString(message.Body));
                await client.CompleteAsync(message.SystemProperties.LockToken);

            }, messageHandlerOptions);

            Console.ReadKey();

            await client.CloseAsync();
        }

        static Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
            return Task.CompletedTask;
        }
    }
}
