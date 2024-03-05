namespace Cinemax.Domain.Interfaces
{
    public interface Identifiable<T>
    {
        public T Id { get; set;}
    }
}