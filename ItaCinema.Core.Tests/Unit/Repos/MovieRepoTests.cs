using ItaCinema.Core.Repos.Interfaces;
using NUnit.Framework;
using System.Linq;

namespace ItaCinema.Core.Tests.Unit.Repos
{
    public class MovieRepoTests
    {
        private readonly IMovieRepo _movieRepo;

        public MovieRepoTests()
        {
            _movieRepo = new MovieRepo();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenGetMovies_MoviesReturned()
        {
            var movies = _movieRepo.Get();

            Assert.IsTrue(
                movies != null && movies.Any()
            );
        }
    }
}
