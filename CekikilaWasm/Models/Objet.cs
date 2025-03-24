namespace CekikilaWasm.Models
{
    public class Objet
    {
        public required string Nom { 
            get;
            set;
        }
    }
    public record Reservation(
        Objet Objet, 
        string Email, 
        DateTime Debut, 
        TimeSpan Duree
    );
}