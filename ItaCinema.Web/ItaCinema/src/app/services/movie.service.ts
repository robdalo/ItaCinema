import { Injectable } from '@angular/core';
import { Movie } from '../interfaces/movie'

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor() { }

  getMovies(): Movie[] {
    return [
      { id: 1, title: 'TENET', description: 'A basic short description of each movie, encapsulated in no more than two sentences. This is the template that we should incorporate.', director: 'Christopher Nolan', ticketPrice: 15.00, imageSmall: 'assets/img/movies/small/tenet.png' },
      { id: 2, title: 'Unhinged', description: 'A basic short description of each movie, encapsulated in no more than two sentences. This is the template that we should incorporate.', director: 'Derrick Borte', ticketPrice: 10.00, imageSmall: 'assets/img/movies/small/unhinged.png' },
      { id: 3, title: 'Proxima', description: 'A basic short description of each movie, encapsulated in no more than two sentences. This is the template that we should incorporate.', director: 'Alice Winocour', ticketPrice: 10.00, imageSmall: 'assets/img/movies/small/proxima.png' }
    ];
  }
}
