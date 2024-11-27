namespace Homework_10_dars.Models;

public class Restaurant
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Location { get; set; }

    public double Rating { get; set; }

    public List<string> Dishes { get; set; } = new List<string>();
}
