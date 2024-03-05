using  Cinemax.Domain.Interfaces;


namespace Cinemax.Domain.Models
{
    public class Entity : Identifiable<string>
    {
        public virtual string Id { get; set; } = Guid.NewGuid().ToString();
        public bool Active { get; set; } = true;
    }
}