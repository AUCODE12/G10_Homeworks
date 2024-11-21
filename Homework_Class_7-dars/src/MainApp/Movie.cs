namespace MainApp;

internal class Movie
{
    public string Genre { get; set; }                // Janr
    public string Title { get; set; }                // Film nomi
    public string Director { get; set; }             // Rejissyor
    public TimeSpan Duration { get; set; }           // Davomiyligi (soat va daqiqalar)
    public double Rating { get; set; }               // Reytingi (1-10)
    public string MainCharacter { get; set; }        // Bosh qahramon
    public int ReleaseYear { get; set; }             // Chiqish yili
    public string Language { get; set; }             // Til
    public string ProductionCompany { get; set; }    // Ishlab chiqaruvchi kompaniya
    public decimal BoxOffice { get; set; }           // Kassadagi daromadi

    public void DisplayInfo()
    {
        string result = $"Computer -> Genre: {Genre}, Title: {Title}, Director: {Director}, Duration: {Duration}, Rating: {Rating}, MainCharacter: {MainCharacter}, ReleaseYear: {ReleaseYear}, Language: {Language}, ProductionCompany: {ProductionCompany}, BoxOffice: {BoxOffice}";
        Console.WriteLine(result);
    }
}
