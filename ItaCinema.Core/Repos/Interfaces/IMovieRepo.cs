using ItaCinema.Domain.Models;
using System.Collections.Generic;

namespace ItaCinema.Core.Repos.Interfaces
{
    public interface IMovieRepo
    {
        List<Movie> Get();
    }
}
