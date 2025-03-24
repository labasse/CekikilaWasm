namespace CekikilaWasm.Models
{
    public class Objet
    {
        public int Id { get; init; }
        public required string Nom { get; set; }
        public string? Description
        {
            get; init;
        }
    }
    public record Reservation(
        Objet Objet, 
        string Email, 
        DateTime Debut, 
        TimeSpan Duree
    );
}