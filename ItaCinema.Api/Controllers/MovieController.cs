using ItaCinema.Core.Consumers.Interfaces;
using ItaCinema.Core.Repos.Interfaces;
using ItaCinema.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ItaCinema.Api.Controllers
{
    [ApiController]
    [Route("api/movie")]
    public class MovieController : Controller
    {
        private readonly IMovieRepo _movieRepo;
        private readonly IMessagePublisher _messagePublisher;

        public MovieController(IMovieRepo movieRepo, IMessagePublisher messagePublisher)
        {
            _movieRepo = movieRepo;
            _messagePublisher = messagePublisher;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return _movieRepo.Get();
        }

        [HttpPost]
        public async void Add(Movie movie)
        {
            await _messagePublisher.Publish(movie);
        }
    }
}
