public interface ICar
{
    string Driver { get; set; }
    string Model { get; } 
    string Brakes();
    string GasPedal();
}