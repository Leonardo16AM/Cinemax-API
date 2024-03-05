using System.ComponentModel.DataAnnotations;

using  Cinemax.Domain.Interfaces;

namespace Cinemax.Domain.Models
{
    public class Projection:Entity
    {
        public int ProjectionId {get; set;}
        public DateTime DateTime {get; set;}
        public int Price {get; set;}
        public int RoomId {get; set;}
        public int MovieID {get; set;}

        // public virtual Room? Room {get; set;}
        // public virtual Movie? Movie {get; set;}
        // public virtual ICollection<Ticket>? Tickets {get; set;}
    }
}
