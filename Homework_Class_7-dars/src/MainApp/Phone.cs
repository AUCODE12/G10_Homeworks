namespace MainApp;

internal class Phone
{
    // Telefon modeli (masalan, iPhone 14)
    public string Model { get; set; }

    // Telefon nomi (masalan, iPhone, Samsung Galaxy)
    public string Name { get; set; }

    // Telefon narxi (Decimal ishlatish tavsiya etiladi)
    public decimal Price { get; set; }

    // Chiqarilgan yili
    public int ReleaseYear { get; set; }

    // Telefonning rangi (masalan, qora, oq)
    public string Color { get; set; }

    // Telefonning operatsion tizimi (masalan, iOS, Android)
    public string OperatingSystem { get; set; }

    // Batareya sig‘imi (mAh)
    public int BatteryCapacity { get; set; }

    // Xotira hajmi (GB)
    public int StorageGB { get; set; }

    // Tezkor xotira hajmi (GB)
    public int RamGB { get; set; }

    // Ekran o‘lchami 
    public double ScreenSizeInches { get; set; }

    public void DisplayInfo()
    {
        string result = $"Phone -> Model: {Model}, Name: {Name}, Price: {Price}, ReleaseYear: {ReleaseYear}, Color: {Color}, OperatingSystem: {OperatingSystem}, BatteryCapacity: {BatteryCapacity}, StorageGB: {StorageGB}, RamGB: {RamGB}, ScreenSizeInches: {ScreenSizeInches}";
        Console.WriteLine(result);
    }
}
