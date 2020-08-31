using ItaCinema.Domain.Models;
using System.Threading.Tasks;

namespace ItaCinema.Core.Consumers.Interfaces
{
    public interface IMessagePublisher
    {
        Task Publish(Movie movie);
    }
}
