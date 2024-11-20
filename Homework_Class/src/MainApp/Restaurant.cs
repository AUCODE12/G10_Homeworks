namespace MainApp;

internal class Restaurant
{
    public string Name { get; set; }          // Restoran nomi
    public string MainLocation { get; set; }  // Asosiy joylashuv
    public int StarRating { get; set; }       // Yulduz reytingi
    public int BranchCount { get; set; }      // Filiallar soni
    public double AnnualRevenue { get; set; } // Yillik daromad
    public string CuisineType { get; set; }   // Oshxona turi (masalan, Turkcha, Yaponcha)
    public int EmployeeCount { get; set; }    // Ishchilar soni
    public string BusinessHours { get; set; } // Ish vaqti (masalan, "09:00-22:00")
    public double CustomerRating { get; set; } // Mijozlar reytingi (masalan, 4.5)
    public int YearsInOperation { get; set; } // Faoliyat yillari

    public void DisplayInfo()
    {
        string result = $"Restaurant -> Name: {Name}, MainLocation: {MainLocation}, StarRating: {StarRating}, BranchCount: {BranchCount}, AnnualRevenue: {AnnualRevenue}, CuisineType: {CuisineType}, EmployeeCount: {EmployeeCount}, BusinessHours: {BusinessHours}, CustomerRating: {CustomerRating}, YearsInOperation: {YearsInOperation}";
        Console.WriteLine(result);
    }
}
