namespace MainApp;

internal class Planet
{
    public string Name { get; set; }                // Planet nomi
    public double Weight { get; set; }              // Massasi (kg)
    public double Diameter { get; set; }            // Diametri (km)
    public double DistanceFromSun { get; set; }     // Quyoshga masofa (km)
    public int MoonCount { get; set; }              // Tabiiy yo‘ldoshlar soni
    public bool HasLife { get; set; }               // Hayot mavjudmi
    public double RotationPeriod { get; set; }      // O‘z o‘qi atrofida aylanish vaqti (kun)
    public double OrbitalPeriod { get; set; }       // Quyosh atrofida aylanish vaqti (yil)
    public string AtmosphereComposition { get; set; } // Atmosferaning tarkibi
    public double SurfaceTemperature { get; set; }  // O‘rtacha sirt harorati (°C yoki Kelvin)

    public void DisplayInfo()
    {
        string result = $"Planet -> Name: {Name}, Weight: {Weight}, Diameter: {Diameter}, DistanceFromSun: {DistanceFromSun}, MoonCount: {MoonCount}, HasLife: {HasLife}, RotationPeriod: {RotationPeriod}, OrbitalPeriod: {OrbitalPeriod}, AtmosphereComposition: {AtmosphereComposition}, SurfaceTemperature: {SurfaceTemperature}";
        Console.WriteLine(result);
    }
}
