using MovieAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppMvc.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Id = 1,Name = "Dune",ShortDescription = "Dune",Description = "<p>Dune is a 2021 American epic science fiction film directed by Denis Villeneuve from a screenplay by Villeneuve, Jon Spaihts, and Eric Roth. It is the first of a two-part adaptation of the 1965 novel by Frank Herbert, primarily covering the first half of the book. Set in the far future, the film follows Paul Atreides as his family, the noble House Atreides, is thrust into a war for the deadly and inhospitable desert planet Arrakis. The ensemble cast includes Timothée Chalamet, Rebecca Ferguson, Oscar Isaac, Josh Brolin, Stellan Skarsgård, Dave Bautista, Stephen McKinley Henderson, Zendaya, David Dastmalchian, Chang Chen, Sharon Duncan-Brewster, Charlotte Rampling, Jason Momoa, and Javier Bardem.</p>",ImageUrl = "dune.jpg",CategoryId = 5},

                new Movie(){Id = 2,Name = "Harry Potter",ShortDescription = "Harry Potter",Description = "<p>Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry. The main story arc concerns Harry's struggle against Lord Voldemort, a dark wizard who intends to become immortal, overthrow the wizard governing body known as the Ministry of Magic and subjugate all wizards and Muggles</p>",ImageUrl = "harry_potter.jpg",CategoryId = 2},

                new Movie(){Id = 3,Name = "Pursuit of Happyness",ShortDescription = "Pursuit of Happyness",Description = "<p>The Pursuit of Happyness is a 2006 American biographical drama film directed by Gabriele Muccino and starring Will Smith as Chris Gardner, a homeless salesman. Smith's son Jaden Smith co-stars, making his film debut as Gardner's son, Christopher Jr. The screenplay by Steven Conrad is based on the best-selling 2006 memoir of the same name written by Gardner with Quincy Troupe. It is based on Gardner's nearly one-year struggle being homeless.[2] The unusual spelling of the film's title comes from a mural that Gardner sees on the wall outside the daycare facility his son attended.The movie is set in San Francisco in 1981.</p>",ImageUrl = "pursuithappyness.jpg",CategoryId = 3},

                new Movie(){Id = 4,Name = "The Intouchables",ShortDescription = "The Intouchables",Description = "<p>The Intouchables (French: Intouchables, pronounced [ɛ̃tuʃablə]), also known as Untouchable in the UK and Ireland, is a 2011 French buddy comedy-drama film written and directed by Olivier Nakache & Éric Toledano. It stars François Cluzet and Omar Sy. Nine weeks after its release in France on 2 November 2011, it became the biggest box office hit in France, just passing the 2008 film Welcome to the Sticks.[2] The film was voted the cultural event of 2011 in France with 52% of votes in a poll by Fnac.[3] Until it was eclipsed in 2014 by Lucy, it was the most viewed French film in the world with 51.5 million tickets sold.[4] The film received several award nominations. In France, the film won the César Award for Best Actor for Sy and garnered seven further nominations for the César Awards, including the César Award for Best Actor. Five percent of the movie's profit were given to Simon de Cyrène, an association that helps paralyzed people.</p>",ImageUrl = "intouchables.jpg",CategoryId = 1},

                new Movie(){Id = 5,Name = "A beautiful mind",ShortDescription = "A beautiful mind",Description = "<p>A Beautiful Mind is a 2001 American biographical drama film directed by Ron Howard. Written by Akiva Goldsman, its screenplay was inspired by Sylvia Nasar's 1997 biography of the mathematician John Nash, a Nobel Laureate in Economics. A Beautiful Mind stars Russell Crowe as Nash, along with Ed Harris, Jennifer Connelly, Paul Bettany, Adam Goldberg, Judd Hirsch, Josh Lucas, Anthony Rapp, and Christopher Plummer in supporting roles. The story begins in Nash's days as a graduate student at Princeton University. Early in the film, Nash begins to develop paranoid schizophrenia and endures delusional episodes while watching the burden his condition brings on his wife Alicia and friends.</p>",ImageUrl = "beautifulmind.jpg",CategoryId = 4},
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }

    }
}
