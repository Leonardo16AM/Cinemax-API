using System.ComponentModel.DataAnnotations;

namespace Cinemax.API.Models
{
    public class Movie{
        [Required]
        public int MovieId {get; set;}
        [Required]
        public string? Name {get; set;}
        [Required]
        public string? Description {get; set;}
        public TimeSpan Duration {get; set;}
        public DateOnly Premiere{get; set;}
        public string? IconURL{get; set;}
        public string? TrailerURL{get; set;}
        

        // public virtual ICollection<Projection>? Projections { get; set; }
        // public virtual ICollection<MovieGenre> MovieGenres { get; set; }
        // public virtual ICollection<MovieActor> MovieActors { get; set; }
        // public virtual ICollection<MovieDirector> MovieDirectors { get; set; }
        // public virtual ICollection<MovieCountry> MovieCountries { get; set; }
        
    }
}