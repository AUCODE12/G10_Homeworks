using Car_Crud_OOP.Models;

namespace Car_Crud_OOP.Services;

internal class CarServices
{
    private List<Car> cars;

    public CarServices()
    {
        cars = new List<Car>();
        DataSeed();
    }

    public Car AddCar(Car car)
    {
        car.Id = Guid.NewGuid();
        cars.Add(car);
        return car;
    }
    public List<Car> GetAllCars()
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
    public bool DeleteCar(Guid carId)
    {
        for (var i = 0; i < cars.Count; i++)
        {
            if (cars[i].Id == carId)
            {
                cars.Remove(cars[i]);
                return true;
            }
        }
        return false;
    }
    private void DataSeed()
    {
        var firstCar = new Car()
        {
            Id = Guid.NewGuid(),
            Name = "Bugatti1",
            Year = new DateTime(2014, 7, 24),
            Color = "Black",
            EngineCapacity = 4.5,
            Price = 000000,
        };
        var secondCar = new Car()
        {
            Id = Guid.NewGuid(),
            Name = "Bugatti2",
            Year = new DateTime(2017, 3, 16),
            Color = "White",
            EngineCapacity = 5.5,
            Price = 000000,
        };
        var thirdCar = new Car()
        {
            Id = Guid.NewGuid(),
            Name = "Bugatti3",
            Year = new DateTime(2009, 12, 9),
            Color = "Gold",
            EngineCapacity = 3.5,
            Price = 000000,
        };
        cars.Add(firstCar);
        cars.Add(secondCar);
        cars.Add(thirdCar);
    }
}
