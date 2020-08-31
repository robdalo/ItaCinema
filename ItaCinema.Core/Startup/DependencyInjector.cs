using ItaCinema.Core.Consumers;
using ItaCinema.Core.Consumers.Interfaces;
using ItaCinema.Core.Repos.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ItaCinema.Core.Startup
{
    public class DependencyInjector
    {
        private readonly string _serviceBusConnectionString;
        public DependencyInjector(string serviceBusConnectionString)
        {
            _serviceBusConnectionString = serviceBusConnectionString;
        }

        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IMovieRepo, MovieRepo>();
            services.AddSingleton<IMessagePublisher>(new MessagePublisher(_serviceBusConnectionString));
            services.AddSingleton<IMessageReceiver>(new MessageReceiver(_serviceBusConnectionString));
        }
    }
}
