using ItaCinema.Core.Consumers.Interfaces;
using ItaCinema.Domain.Models;
using ItaCinema.SDK.Consumers;
using Microsoft.Azure.ServiceBus;
using System.Text;
using System.Threading.Tasks;

namespace ItaCinema.Core.Consumers
{
    public class MessagePublisher : IMessagePublisher
    {
        private readonly string _connectionString;

        private const string MovieQueueName = "movie";

        public MessagePublisher(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task Publish(Movie movie)
        {
            var client = new QueueClient(_connectionString, MovieQueueName);
            var json = Serializer.Serialize(movie);
            var message = new Message(Encoding.UTF8.GetBytes(json));

            await client.SendAsync(message);
            await client.CloseAsync();
        }
    }
}
