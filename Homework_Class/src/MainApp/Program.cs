namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Animal
            var animals = new List<Animal>();
            var animalDog = new Animal()
            {
                Name = "Flash",
                Age = 2,
                Type = "It",
                Gender = "Male",
                Weight = 5.2,
                Color = "Black",
                MovementType = "Yuradi",
                Habitat = "Uy",
                Diet = "Go'shtxo'r",
                IsDomestic = true
            };
            var animalCat = new Animal()
            {
                Name = "Mushuk",
                Age = 2,
                Type = "Mushuk",
                Gender = "Female",
                Weight = 3.2,
                Color = "White",
                MovementType = "Yuradi",
                Habitat = "Uy",
                Diet = "Go'shtxo'r",
                IsDomestic = true
            };
            var animalWhiteBear = new Animal()
            {
                Name = "Oq ayiq",
                Age = 5,
                Type = "Oq Ayiq",
                Gender = "Female",
                Weight = 400,
                Color = "White",
                MovementType = "Yuradi",
                Habitat = "Muzlik",
                Diet = "Go'shtxo'r",
                IsDomestic = false
            };
            animals.Add(animalDog);
            animals.Add(animalCat);
            animals.Add(animalWhiteBear);
            foreach (var animal in animals)
            {
                animal.DisplayInfo();
            }
            Console.WriteLine();

            // Restaurant
            var restaurants = new List<Restaurant>();
            var firstRestaurant = new Restaurant()
            {
                Name = "Hammersmit",
                MainLocation = "Toshkent",
                StarRating = 5,
                BranchCount = 3,
                AnnualRevenue = 5000000,
                CuisineType = "Italiya",
                EmployeeCount = 50,
                BusinessHours = "09:00-22:00",
                CustomerRating = 4.8,
                YearsInOperation = 7
            };
            var secondRestaurant = new Restaurant()
            {
                Name = "Sushiya",
                MainLocation = "Samarqand",
                StarRating = 4,
                BranchCount = 2,
                AnnualRevenue = 3000000,
                CuisineType = "Yapon",
                EmployeeCount = 35,
                BusinessHours = "10:00-23:00",
                CustomerRating = 4.6,
                YearsInOperation = 5
            };
            var thirdRestaurant = new Restaurant()
            {
                Name = "Meksika Tacos",
                MainLocation = "Buxoro",
                StarRating = 3,
                BranchCount = 1,
                AnnualRevenue = 1500000,
                CuisineType = "Meksika",
                EmployeeCount = 20,
                BusinessHours = "11:00-21:00",
                CustomerRating = 4.2,
                YearsInOperation = 3
            };
            restaurants.Add(firstRestaurant);
            restaurants.Add(secondRestaurant);
            restaurants.Add(thirdRestaurant);
            foreach (var restaurant in restaurants)
            {
                restaurant.DisplayInfo();
            }
            Console.WriteLine();

            // Book
            var books = new List<Book>();
            var firstBook = new Book()
            {
                Title = "Dahshatli Odam",
                Price = 25.99,
                Author = "John Smith",
                Genre = "Thriller",
                PageCount = 320,
                Language = "Ingliz",
                WrittenYear = "2021",
                Publisher = "Xalq Noshirlik",
                Rating = 4.5,
                ISBN = "978-3-16-148410-0"
            };
            var secondBook = new Book()
            {
                Title = "Yurtimning Tarixi",
                Price = 15.49,
                Author = "Azizbek Yuldoshev",
                Genre = "Tarix",
                PageCount = 250,
                Language = "O'zbek",
                WrittenYear = "2018",
                Publisher = "Mavjud Noshir",
                Rating = 4.8,
                ISBN = "978-1-59-327158-6"
            };
            var thirdBook = new Book()
            {
                Title = "Qahramonlarning Izlari",
                Price = 12.99,
                Author = "Maria Johnson",
                Genre = "Fentezi",
                PageCount = 450,
                Language = "Fransuz",
                WrittenYear = "2015",
                Publisher = "Vahiy Noshirlik",
                Rating = 4.2,
                ISBN = "978-0-45-152493-5"
            };
            books.Add(firstBook);
            books.Add(secondBook);
            books.Add(thirdBook);
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
            Console.WriteLine();

            // House
            var houses = new List<House>();
            var firstHouse = new House()
            {
                Location = "Toshkent, Mirzo Ulug'bek ko'chasi, O'zbekiston",
                Price = 1200000.50m,
                FloorCount = 2,
                Area = 180.5,
                RoomsCount = 5,
                OwnerName = "Dostonbek Abdullayev",
                YearBuilt = 2015,
                HasGarden = true,
                HasGarage = true,
                BuildingType = "Xususiy uy"
            };
            var secondHouse = new House()
            {
                Location = "Samarqand, Beshik ko'chasi, O'zbekiston",
                Price = 850000.75m,
                FloorCount = 1,
                Area = 120.2,
                RoomsCount = 4,
                OwnerName = "Olimbek Tursunov",
                YearBuilt = 2010,
                HasGarden = true,
                HasGarage = false,
                BuildingType = "Xususiy uy"
            };
            var thirdHouse = new House()
            {
                Location = "Buxoro, Markaziy ko'cha, O'zbekiston",
                Price = 1500000.00m,
                FloorCount = 3,
                Area = 220.8,
                RoomsCount = 6,
                OwnerName = "Dilorom G'ulomova",
                YearBuilt = 2020,
                HasGarden = true,
                HasGarage = true,
                BuildingType = "Ko'pxonali uy"
            };
            houses.Add(firstHouse);
            houses.Add(secondHouse);
            houses.Add(thirdHouse);
            foreach (var house in houses)
            {
                house.DisplayInfo();
            }
            Console.WriteLine();

            // Phone
            var phones = new List<Phone>();
            var firstPhone = new Phone()
            {
                Model = "iPhone 14 Pro",
                Name = "Apple iPhone 14 Pro",
                Price = 999.99m,
                ReleaseYear = 2022,
                Color = "Space Black",
                OperatingSystem = "iOS",
                BatteryCapacity = 3095,
                StorageGB = 128,
                RamGB = 6,
                ScreenSizeInches = 6.1
            };
            var secondPhone = new Phone()
            {
                Model = "Samsung Galaxy S23",
                Name = "Samsung Galaxy S23",
                Price = 799.99m,
                ReleaseYear = 2023,
                Color = "Phantom Black",
                OperatingSystem = "Android",
                BatteryCapacity = 3900,
                StorageGB = 128,
                RamGB = 8,
                ScreenSizeInches = 6.1
            };
            var thirdPhone = new Phone()
            {
                Model = "Google Pixel 8",
                Name = "Google Pixel 8",
                Price = 599.99m,
                ReleaseYear = 2023,
                Color = "Obsidian",
                OperatingSystem = "Android",
                BatteryCapacity = 4355,
                StorageGB = 128,
                RamGB = 8,
                ScreenSizeInches = 6.2
            };
            phones.Add(firstPhone);
            phones.Add(secondPhone);
            phones.Add(thirdPhone);
            foreach (var phone in phones)
            {
                phone.DisplayInfo();
            }
            Console.WriteLine();

            // School
            var schools = new List<School>();
            var firstSchool = new School()
            {
                Name = "Toshkent International School",
                Location = "Toshkent, O'zbekiston",
                EstablishedYear = 2005,
                StudentCount = 1200,
                Principal = "Abdurahmon Tursunov",
                Type = "Xususiy",
                ClassCount = 30,
                SubjectCount = 15,
                TeacherCount = 100
            };
            var secondSchool = new School()
            {
                Name = "Samarqand Davlat Maktabi",
                Location = "Samarqand, O'zbekiston",
                EstablishedYear = 1998,
                StudentCount = 800,
                Principal = "Zuhra G'ulomova",
                Type = "Davlat",
                ClassCount = 25,
                SubjectCount = 10,
                TeacherCount = 50
            };
            var thirdSchool = new School()
            {
                Name = "Buxoro Oliy Maktabi",
                Location = "Buxoro, O'zbekiston",
                EstablishedYear = 2010,
                StudentCount = 1500,
                Principal = "Murodjon Tashkentov",
                Type = "Xususiy",
                ClassCount = 35,
                SubjectCount = 18,
                TeacherCount = 120
            };
            schools.Add(firstSchool);
            schools.Add(secondSchool);
            schools.Add(thirdSchool);
            foreach (var school in schools)
            {
                school.DisplayInfo();
            }
            Console.WriteLine();

            // Movie
            var movies = new List<Movie>();
            var firstMovie = new Movie()
            {
                Genre = "Drama",
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Duration = new TimeSpan(2, 22, 0),
                Rating = 9.3,
                MainCharacter = "Tim Robbins",
                ReleaseYear = 1994,
                Language = "English",
                ProductionCompany = "Castle Rock Entertainment",
                BoxOffice = 28341469m
            };
            var secondMovie = new Movie()
            {
                Genre = "Action",
                Title = "Avengers: Endgame",
                Director = "Anthony Russo, Joe Russo",
                Duration = new TimeSpan(3, 2, 0),
                Rating = 8.4,
                MainCharacter = "Robert Downey Jr.",
                ReleaseYear = 2019,
                Language = "English",
                ProductionCompany = "Marvel Studios",
                BoxOffice = 2797800564m
            };
            var thirdMovie = new Movie()
            {
                Genre = "Comedy",
                Title = "The Grand Budapest Hotel",
                Director = "Wes Anderson",
                Duration = new TimeSpan(1, 39, 0),
                Rating = 8.1,
                MainCharacter = "Ralph Fiennes",
                ReleaseYear = 2014,
                Language = "English",
                ProductionCompany = "Fox Searchlight Pictures",
                BoxOffice = 17483443m
            };
            movies.Add(firstMovie);
            movies.Add(secondMovie);
            movies.Add(thirdMovie);
            foreach (var movie in movies)
            {
                movie.DisplayInfo();
            }
            Console.WriteLine();

            // Computer
            var computers = new List<Computer>();
            var firstComputer = new Computer()
            {
                Type = "Laptop",
                Name = "Dell XPS 13",
                Price = 1299.99,
                Processor = "Intel Core i7-1185G7",
                Storage = "512 GB SSD",
                RAM = "16 GB",
                ReleaseYear = 2021,
                GraphicsCard = "Intel Iris Xe",
                OperatingSystem = "Windows 10",
                Weight = 1.2
            };
            var secondComputer = new Computer()
            {
                Type = "Desktop",
                Name = "Apple iMac 27-inch",
                Price = 2399.99,
                Processor = "Intel Core i9-10910",
                Storage = "1 TB SSD",
                RAM = "32 GB",
                ReleaseYear = 2020,
                GraphicsCard = "AMD Radeon Pro 5700 XT",
                OperatingSystem = "macOS",
                Weight = 8.25
            };
            var thirdComputer = new Computer()
            {
                Type = "Laptop",
                Name = "HP Spectre x360",
                Price = 1499.99,
                Processor = "Intel Core i7-1165G7",
                Storage = "1 TB SSD",
                RAM = "16 GB",
                ReleaseYear = 2022,
                GraphicsCard = "Intel Iris Xe",
                OperatingSystem = "Windows 11",
                Weight = 1.3
            };
            computers.Add(firstComputer);
            computers.Add(secondComputer);
            computers.Add(thirdComputer);
            foreach (var computer in computers)
            {
                computer.DisplayInfo();
            }
            Console.WriteLine();

            // Game
            var games = new List<Game>();
            var firstGame = new Game()
            {
                Name = "The Witcher 3: Wild Hunt",
                Genre = "Action RPG",
                ReleaseYear = "2015",
                Size = 50.6,
                Publisher = "CD Projekt",
                Platform = "PC, Xbox, PlayStation",
                Rating = 9.8,
                MultiplayerSupport = false,
                Price = 39.99,
                Developer = "CD Projekt Red"
            };
            var secondGame = new Game()
            {
                Name = "Minecraft",
                Genre = "Sandbox, Survival",
                ReleaseYear = "2011",
                Size = 200,
                Publisher = "Mojang Studios",
                Platform = "PC, Xbox, PlayStation, Switch, Mobile",
                Rating = 9.0,
                MultiplayerSupport = true,
                Price = 26.95,
                Developer = "Mojang Studios"
            };
            var thirdGame = new Game()
            {
                Name = "Call of Duty: Modern Warfare II",
                Genre = "First-Person Shooter",
                ReleaseYear = "2022",
                Size = 60.0,
                Publisher = "Activision",
                Platform = "PC, Xbox, PlayStation",
                Rating = 8.5,
                MultiplayerSupport = true,
                Price = 59.99,
                Developer = "Infinity Ward"
            };
            games.Add(firstGame);
            games.Add(secondGame);
            games.Add(thirdGame);
            foreach (var game in games)
            {
                game.DisplayInfo();
            }
            Console.WriteLine();

            // Planet
            var planets = new List<Planet>();
            var firstPlanet = new Planet()
            {
                Name = "Earth",
                Weight = 5.972e24,
                Diameter = 12742,
                DistanceFromSun = 149.6e6,
                MoonCount = 1,
                HasLife = true,
                RotationPeriod = 24,
                OrbitalPeriod = 365.25,
                AtmosphereComposition = "78% Nitrogen, 21% Oxygen, 1% Other gases",
                SurfaceTemperature = 15.0
            };
            var secondPlanet = new Planet()
            {
                Name = "Mars",
                Weight = 0.64171e24,
                Diameter = 6779,
                DistanceFromSun = 227.9e6,
                MoonCount = 2,
                HasLife = false,
                RotationPeriod = 24.6,
                OrbitalPeriod = 687,
                AtmosphereComposition = "95% Carbon Dioxide, 3% Nitrogen, 1.6% Argon",
                SurfaceTemperature = -63.0
            };
            var thirdPlanet = new Planet()
            {
                Name = "Jupiter",
                Weight = 1.898e27,
                Diameter = 139820,
                DistanceFromSun = 778.5e6,
                MoonCount = 79,
                HasLife = false,
                RotationPeriod = 9.9,
                OrbitalPeriod = 4333,
                AtmosphereComposition = "90% Hydrogen, 10% Helium",
                SurfaceTemperature = -145.0
            };
            planets.Add(firstPlanet);
            planets.Add(secondPlanet);
            planets.Add(thirdPlanet);
            foreach (var planet in planets)
            {
                planet.DisplayInfo();
            }
            Console.WriteLine();

        }
    }
}
