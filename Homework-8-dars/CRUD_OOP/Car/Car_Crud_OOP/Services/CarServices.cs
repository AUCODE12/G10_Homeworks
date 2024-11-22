using Car_Crud_OOP.Models;

namespace Car_Crud_OOP.Services;

internal class CarServices
{
    private List<Car> cars;

    public CarServices()
    {
        cars = new List<Car>();
    }

    public Car AddCar(Car car)
    {
        car.Id = Guid.NewGuid();
        cars.Add(car);
        return car;
    }
    public List<Car> GetCars()
    {
        return cars;
    }
    public Car GetCarById(Guid carId)
    {
        foreach (var car in cars)
        {
            if (car.Id == carId) return car;
        }

        return null;
    }
    public bool UpdateCar(Car updateCar)
    {
        for (var i = 0; i < cars.Count; i++)
        {
            if (cars[i].Id == updateCar.Id)
            {
                cars[i] = updateCar;
                return true;
            }
        }
        return false;
    }
    public
}
