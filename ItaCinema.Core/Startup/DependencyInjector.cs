using ItaCinema.Core.Repos.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ItaCinema.Core.Startup
{
    public class DependencyInjector
    {
        public DependencyInjector()
        {
        }

        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IMovieRepo, MovieRepo>();
        }
    }
}
