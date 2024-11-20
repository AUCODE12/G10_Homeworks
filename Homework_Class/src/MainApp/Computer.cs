namespace MainApp;

internal class Computer
{
    public string Type { get; set; }             // Kompyuter turi (Laptop, Desktop)
    public string Name { get; set; }             // Model nomi
    public double Price { get; set; }            // Narxi
    public string Processor { get; set; }        // Protsessor turi
    public string Storage { get; set; }          // Doimiy xotira hajmi
    public string RAM { get; set; }              // Tezkor xotira hajmi
    public int ReleaseYear { get; set; }         // Chiqish yili
    public string GraphicsCard { get; set; }     // Videokarta turi
    public string OperatingSystem { get; set; }  // Operatsion tizim
    public double Weight { get; set; }           // Og‘irligi (kg)

    public void DisplayInfo()
    {
        string result = $"Computer -> Type: {Type}, Name: {Name}, Price: {Price}, Processor: {Processor}, Storage: {Storage}, RAM: {RAM}, ReleaseYear: {ReleaseYear}, GraphicsCard: {GraphicsCard}, OperatingSystem: {OperatingSystem}, Weight: {Weight}";
        Console.WriteLine(result);
    }
}
