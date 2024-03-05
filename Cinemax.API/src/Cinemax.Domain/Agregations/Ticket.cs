using System.ComponentModel.DataAnnotations;

using  Cinemax.Domain.Interfaces;

namespace Cinemax.Domain.Models
{
    public class Ticket:Entity
    {
        public int TicketId {get; set;}
        public int ChairId {get; set;}
        public int UserId {get; set;}
        public int ProjectionId {get; set;}
        public int PaymentTypeId {get; set;}
        // public virtual Chair Chair {get; set;}
        // public virtual User User {get; set;}
        // public virtual Projection Projection {get; set;}
        // public virtual PaymentType PaymentType {get; set;}
        // public virtual ICollection<TicketCard>? TicketCards {get; set;}
        // public virtual ICollection<TicketDiscount>? TicketDiscounts {get; set;}
    }
}