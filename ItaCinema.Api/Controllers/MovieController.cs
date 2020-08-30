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

        public MovieController(IMovieRepo movieRepo)
        {
            _movieRepo = movieRepo;
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
    }
}
