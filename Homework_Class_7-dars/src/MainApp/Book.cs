namespace MainApp;

internal class Book
{
    public string Title { get; set; }           // Kitob nomi
    public double Price { get; set; }           // Narx
    public string Author { get; set; }          // Muallif
    public string Genre { get; set; }           // Janr
    public int PageCount { get; set; }          // Sahifa soni
    public string Language { get; set; }        // Til
    public string WrittenYear { get; set; }     // Yozilgan yil
    public string Publisher { get; set; }       // Noshir
    public double Rating { get; set; }          // Kitob reytingi (1 dan 5 gacha)
    public string ISBN { get; set; }            // ISBN kodi

    public void DisplayInfo()
    {
        string result = $"Book -> Title: {Title}, Price: {Price}, Author: {Author}, Genre: {Genre}, PageCount: {PageCount}, Language: {Language}, WrittenYear: {WrittenYear}, Publisher: {Publisher}, Rating: {Rating}, ISBN: {ISBN}";
        Console.WriteLine(result);
    }
}
