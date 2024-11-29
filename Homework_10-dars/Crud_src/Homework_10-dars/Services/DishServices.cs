using Homework_10_dars.Models;

namespace Homework_10_dars.Services;

public class DishServices
{
    private List<Dish> dishes;

    public DishServices()
    {
        dishes = new List<Dish>();
    }

    // Add
    public Dish AddDish(Dish dish)
    {
        dish.Id = Guid.NewGuid();
        dishes.Add(dish);

        return dish;
    }

    // Read (Get)
    public List<Dish> GetAllDish()
    {
        return dishes;
    }
    public Dish GetDishById(Guid id)
    {
        foreach (var dish in dishes)
        {
            if (dish.Id == id)
            {
                return dish;
            }
        }

        return null;
    }
    
    // Update
    public bool UpdateDish(Dish newDish)
    {
        var requestFromDb = GetDishById(newDish.Id);
        if (requestFromDb is null)
        {
            return false;
        }
        var index = dishes.IndexOf(requestFromDb);
        dishes[index] = newDish;

        return true;
    }

    // Delete
    public bool DeleteDish(Guid id)
    {
        var requestFromDb = GetDishById(id);
        if (requestFromDb is null)
        {
            return false;
        }
        dishes.Remove(requestFromDb);

        return true;
    }

    // DateSeed

    // Check
    private bool CheckDishes()
    {
        if (dishes == null || dishes.Count == 0)
        {
            return false;
        }

        return true;
    }
}
