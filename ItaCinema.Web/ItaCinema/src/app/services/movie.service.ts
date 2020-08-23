import { Injectable } from '@angular/core';
import { Movie } from '../interfaces/movie'

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor() { }

  getMovies(): Movie[] {
    return [
      { id: 1, title: 'TENET', description: 'Armed with only one word, Tenet, and fighting for the survival of the entire world, a Protagonist journeys through a twilight world of international espionage on a mission that will unfold in something beyond real time.', director: 'Christopher Nolan', ticketPrice: 15.00, imageSmall: 'assets/img/movies/small/tenet.png' },
      { id: 2, title: 'Unhinged', description: 'After a confrontation with an unstable man at an intersection, a woman becomes the target of his rage.', director: 'Derrick Borte', ticketPrice: 10.00, imageSmall: 'assets/img/movies/small/unhinged.png' },
      { id: 3, title: 'Proxima', description: 'An astronaut prepares for a one-year mission aboard the International Space Station.', director: 'Alice Winocour', ticketPrice: 10.00, imageSmall: 'assets/img/movies/small/proxima.png' }
    ];
  }
}
