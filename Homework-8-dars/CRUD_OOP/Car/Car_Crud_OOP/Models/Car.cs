namespace Car_Crud_OOP.Models;

internal class Car
{
    public Guid Id { get; set; } // Id

    public string Name { get; set; } // Avtomobil nomi

    public DateTime Year { get; set; } // Model yili

    public string Color { get; set; } // Rang

    public double EngineCapacity { get; set; } // Dvigatel hajmi

    public decimal Price { get; set; } // Narxi
}
