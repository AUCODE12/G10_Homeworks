namespace MainApp;

internal class House
{
    // Uy joylashuvi (shahar, ko'cha, mamlakat)
    public string Location { get; set; }

    // Uyning narxi
    public decimal Price { get; set; }

    // Qavatlar soni
    public int FloorCount { get; set; }

    // Uy maydoni (kvadrat metr)
    public double Area { get; set; }

    // Xonalar soni
    public int RoomsCount { get; set; }

    // Egasi ismi
    public string OwnerName { get; set; }

    // Qurilgan yili
    public int YearBuilt { get; set; }

    // Bog'i borligi (ha yoki yo'q)
    public bool HasGarden { get; set; }

    // Avtomobil garaji borligi (ha yoki yo'q)
    public bool HasGarage { get; set; }

    // Bino turi (masalan, xususiy uy, kvartira, ko'pxonali uy)
    public string BuildingType { get; set; }

    public void DisplayInfo()
    {
        string result = $"House -> Location: {Location}, Price: {Price}, FloorCount: {FloorCount}, Area: {Area}, RoomsCount: {RoomsCount}, OwnerName: {OwnerName}, YearBuilt: {YearBuilt}, HasGarden: {HasGarden}, HasGarage: {HasGarage}, BuildingType: {BuildingType}";
        Console.WriteLine(result);
    }
}
