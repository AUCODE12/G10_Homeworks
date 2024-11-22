using Car_Crud_OOP.Models;
using Car_Crud_OOP.Services;

namespace Car_Crud_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {
            var carServices = new CarServices();
        
            while (true)
            {
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Read Car");
                Console.WriteLine("3. Update Car");
                Console.WriteLine("4. Delate Car");
                Console.WriteLine("0. Read by Id Car");

                Console.Write("Enter Choose: ");
                var option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (option == 0)
                {
                    Console.Write("Enter id: ");
                    var readId = Guid.Parse(Console.ReadLine());
                    var car = carServices.GetCarById(readId);
                    var info = $"Id: {car.Id} \nName: {car.Name} \nYear: {car.Year} \nColor: {car.Color} \nEngine Capacity: {car.EngineCapacity} \nPrice: {car.Price}";
                    Console.WriteLine(info);
                }
                else if (option == 1)
                {
                    var car = new Car();
                    Console.Write("Name: ");
                    car.Name = Console.ReadLine();
                    car.Year = DateTime.Now;
                    Console.Write("Color: ");
                    car.Color = Console.ReadLine();
                    Console.Write("Engine Capacity: ");
                    car.EngineCapacity = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Price: ");
                    car.Price = Convert.ToDecimal(Console.ReadLine());

                    carServices.AddCar(car);
                }
                else if (option == 2)
                {
                    var cars = carServices.GetAllCars();
                    foreach (var car in cars)
                    {
                        var info = $"Id: {car.Id} \nName: {car.Name} \nYear: {car.Year} \nColor: {car.Color} \nEngine Capacity: {car.EngineCapacity} \nPrice: {car.Price}";
                        Console.WriteLine($"{info} \n");
                    }
                }
                else if (option == 3)
                {
                    var updateCar = new Car();
                    Console.Write("Enter Id to update: ");
                    updateCar.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    updateCar.Name = Console.ReadLine();
                    updateCar.Year = DateTime.Now;
                    Console.Write("Color: ");
                    updateCar.Color = Console.ReadLine();
                    Console.Write("Engine Capacity: ");
                    updateCar.EngineCapacity = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Price: ");
                    updateCar.Price = Convert.ToDecimal(Console.ReadLine());

                    carServices.UpdateCar(updateCar);
                }
                else if (option == 4)
                {
                    Console.Write("Enter Id to delete: ");
                    var id = Guid.Parse(Console.ReadLine());
                    var requestDelete = carServices.DeleteCar(id);
                    if (requestDelete is true)
                    {
                        Console.WriteLine("Deleted");
                    }
                    else
                    {
                        Console.WriteLine("Not deleted");
                    }
                }

                Console.ReadKey();
                Console.Clear();
            } 
            
        }
    }
}
