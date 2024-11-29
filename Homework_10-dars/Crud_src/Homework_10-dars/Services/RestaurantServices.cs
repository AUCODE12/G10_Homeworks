using Homework_10_dars.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework_10_dars.Services;

public class RestaurantServices
{
    private List<Restaurant> restaurants;

    public RestaurantServices()
    {
        restaurants = new List<Restaurant>();
    }

    // Add
    public Restaurant AddRestaurant(Restaurant restaurant)
    {
        restaurant.Id = Guid.NewGuid();
        restaurants.Add(restaurant);

        return restaurant;
    }

    // Read (Get)
    public List<Restaurant> GetAllRestaurants()
    {
        return restaurants;
    }
    public Restaurant GetRestaurantById(Guid id)
    {
        foreach (var restaurant in restaurants)
        {
            if (restaurant.Id == id)
            {
                return restaurant;
            }
        }

        return null;
    }
    public Restaurant GetTopRatedRestaurant()
    {
        if (CheckRestaurants() is false)
        {
            return null;
        }
        var topRatedRestaurant = new Restaurant();
        foreach (var restaurant in restaurants)
        {
            if (restaurant.Rating > topRatedRestaurant.Rating)
            {
                topRatedRestaurant = restaurant;
            }
        }

        return topRatedRestaurant;
    }
    public Dish GetMostExpensiveDishByRestaurant()
    {
        if (CheckRestaurants() is false)
        {
            return null;
        }
        var mostExpensiveDishByRestaurant = new Restaurant();
        foreach (var restaurant in restaurants)
        {
            foreach (var dish in restaurant.Dishes)
            {
                
            }
        }

        return mostExpensiveDishByRestaurant;
    }
    // Update
    public bool UpdateRestaurant(Restaurant newRestaurant)
    {
        var requestFromDb = GetRestaurantById(newRestaurant.Id);
        if (requestFromDb is null)
        {
            return false;
        }
        var index = restaurants.IndexOf(requestFromDb);
        restaurants[index] = newRestaurant;

        return true;
    }

    // Delete 
    public bool DeleteRestaurant(Guid id)
    {
        var requestFromDb = GetRestaurantById(id);
        if (requestFromDb is null)
        {
            return false;
        }
        restaurants.Remove(requestFromDb);

        return true;
    }

    // DataSeed

    // Check
    private bool CheckRestaurants()
    {
        if (restaurants == null || restaurants.Count == 0)
        {
            return false;
        }

        return true;
    }
}
