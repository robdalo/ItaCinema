﻿using ItaCinema.Core.Repos.Interfaces;
using ItaCinema.Domain.Models;
using System.Collections.Generic;

namespace ItaCinema.Core
{
    public class MovieRepo : IMovieRepo
    {
        public MovieRepo()
        {
        }

        public List<Movie> Get()
        {
            var movies = new List<Movie>()
            {
                new Movie { Name = "TENET", Description = "A basic short description of each movie, encapsulated in no more than two sentences. This is the template that we should incorporate.", Director = "Christopher Nolan" },
                new Movie { Name = "Unhinged", Description = "A basic short description of each movie, encapsulated in no more than two sentences. This is the template that we should incorporate.", Director = "Derrick Borte" },
                new Movie { Name = "Proxima", Description = "A basic short description of each movie, encapsulated in no more than two sentences. This is the template that we should incorporate.", Director = "Alice Winocour" }
            };

            return movies;
        }
    }
}
