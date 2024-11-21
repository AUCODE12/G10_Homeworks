namespace MainApp;

internal class Game
{
    public string Name { get; set; }                // O‘yin nomi
    public string Genre { get; set; }               // Janri
    public string ReleaseYear { get; set; }         // Chiqish yili
    public double Size { get; set; }                // Hajmi (GB yoki MB)
    public string Publisher { get; set; }           // Nashriyotchi kompaniya
    public string Platform { get; set; }            // Platforma (PC, Xbox, PlayStation va boshqalar)
    public double Rating { get; set; }              // Reyting (1 dan 10 gacha yoki foydalanuvchi bahosi)
    public bool MultiplayerSupport { get; set; }    // Multiplayer rejimi mavjudmi
    public double Price { get; set; }               // Narxi
    public string Developer { get; set; }           // Ishlab chiquvchi kompaniya

    public void DisplayInfo()
    {
        string result = $"Game -> Name: {Name}, Genre: {Genre}, ReleaseYear: {ReleaseYear}, Size: {Size}, Publisher: {Publisher}, Platform: {Platform}, Rating: {Rating}, MultiplayerSupport: {MultiplayerSupport}, Price: {Price}, Developer: {Developer}";
        Console.WriteLine(result);
    }
}
