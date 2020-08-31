using ItaCinema.Domain.Models;
using System.Threading.Tasks;

namespace ItaCinema.Core.Consumers.Interfaces
{
    public interface IMessageReceiver
    {
        Task Receive();
    }
}
