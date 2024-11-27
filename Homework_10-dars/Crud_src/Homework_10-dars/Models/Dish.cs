namespace Homework_10_dars.Models;

public class Dish
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public string Description { get; set; }

    public Guid RestaurentId { get; set; }
}
