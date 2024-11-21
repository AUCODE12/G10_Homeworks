namespace MainApp;

internal class Animal
{
    public string Type { get; set; }          // Hayvon turi (masalan, "Mushuk", "It")
    public string Name { get; set; }          // Hayvon ismi
    public int Age { get; set; }             // Yoshi
    public string Gender { get; set; }       // Jins (erkak, urg‘ochi)
    public double Weight { get; set; }       // Vazni (double sifatida)
    public string Color { get; set; }        // Rangi
    public string MovementType { get; set; } // Harakat turi (yuradi, suzadi, uchadi)
    public string Habitat { get; set; }      // Yashash joyi (o‘rmon, uy, suv)
    public string Diet { get; set; }         // Ovqatlanish turi (o‘txo‘r, go‘shtxo‘r)
    public bool IsDomestic { get; set; }     // Uy hayvoni (true/false)

    public void DisplayInfo()
    {
        string result = $"Animal -> Name: {Name}, Type: {Type}, Age: {Age}, Gender: {Gender}, Weight: {Weight}, Color: {Color}, Movement Type: {MovementType}, Habitat: {Habitat}, Diet: {Diet}, Is Domestic: {IsDomestic}";
        Console.WriteLine(result);
    }
}
