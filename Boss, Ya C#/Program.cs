using static BossYaCsharp.Sword;

namespace BossYaCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scooter = new Scooter
            {
                RentalCostPerMinute = 1.2m,
                Model = "Google",
                Year = 2000
            };

            var scooterRental = new TransportRental<Scooter>("Иванов Иван Иванович", scooter, 120);
            Console.WriteLine(scooterRental.GetRentalInfo());
            Console.WriteLine($"Общая стоимость аренды: {scooterRental.CalculateTotalCost()}\n");




            var car = new Car
            {
                RentalCostPerMinute = 15m,
                LicensePlate = "123",
                Make = "Toyota",
                Model = "Camry",
                Color = "White"
            };

            var carRental = new TransportRental<Car>("Петров Петр Петрович", car, 60);
            Console.WriteLine(carRental.GetRentalInfo());
            Console.WriteLine($"Общая стоимость аренды: {carRental.CalculateTotalCost()}");

            Sword sword = new()
            {
                WeaponPower = 10,
                SpecialAbility = "Парирование",
                Quality = SwordQuality.Уникальное
            };


            CharacterInGame<Sword> okr = new CharacterInGame<Sword>(
                "ДИМА", "Орк", sword, 70);

            Console.WriteLine(okr.GetCharacterInfo());
            Console.WriteLine($"Суммарная сила: {okr.GetPower()}");


            Bow bow = new()
            {
                WeaponPower = 20,
                SpecialAbility = "Двойной выстрел",
                Range = 100,
                Accuracy = 75
            };


            CharacterInGame<Bow> archer = new CharacterInGame<Bow>(
                "Сайриса", "Эльф", bow, 7);

            Console.WriteLine(archer.GetCharacterInfo());
            Console.WriteLine($"Суммарная сила: {archer.GetPower()}");
            var bread = new Necessites
            {
                ProductName = "Хлеб",
                ProductCost = 30
            };

            var gold = new Lux
            {
                ProductName = "Золото",
                ProductCost = 99999999
            };

            bread.Print(); gold.Print();

            var manager = new Manager
            {
                FullName = "Сегежа",
                WorkingDays = 15
            };

            var departament = new DepartamentHead
            {
                FullName = "Ппанасекоыв",
                WorkingDays = 14
            };
            manager.Print(); departament.Print();

            List<Car1> cars =
            [
                new Car1()
                {
                    VinNumEngine = "001",
                    Brand = "Lada",
                    Color = "White ",
                    Model = "Vesta",
                    Year = 2004
                },

                new Car1()
                {
                    VinNumEngine = "002",
                    Brand = "Lada",
                    Color = "Black ",
                    Model = "Vesta",
                    Year = 2000
                },

                new Car1()
                {
                    VinNumEngine = "003",
                    Brand = "Lada",
                    Color = "Green ",
                    Model = "Vesta",
                    Year = 2000
                },
                new Car1()
                {
                    VinNumEngine = "004",
                    Brand = "Lada",
                    Color = "Blue",
                    Model = "Vesta",
                    Year = 2004
                },
                new Car1()
                {
                    VinNumEngine = "005",
                    Brand = "MikelJordan",
                    Color = "Black ",
                    Model = "Olympick game",
                    Year = 1999
                }
            ];
            foreach (var car1 in cars)
            {
                Console.WriteLine(car1.Info);
            }
            Console.WriteLine("\nДобавление новой машины:");
            Car1 newCar = new();

            Console.Write("Введите VIN номер двигателя: ");
            newCar.VinNumEngine = Console.ReadLine();

            Console.Write("Введите марку: ");
            newCar.Brand = Console.ReadLine();

            Console.Write("Введите модель: ");
            newCar.Model = Console.ReadLine();

            Console.Write("Введите год выпуска: ");
            newCar.Year = int.Parse(Console.ReadLine());

            Console.Write("Введите цвет: ");
            newCar.Color = Console.ReadLine();

            cars.Add(newCar);
            cars = cars.OrderBy(x => x.Year).ToList();


            Console.Write("\nВведите VIN номер для поиска и удаления: ");
            string vinToDelete = Console.ReadLine();

            Car1? carToDelete = cars.FirstOrDefault(c => c.VinNumEngine == vinToDelete);
            cars.Remove((Car1)carToDelete);
            Console.WriteLine("Машина с указанным VIN удалена.");

            foreach (var car1 in cars)
            {
                Console.WriteLine(car1.Info);
            }
            Console.Write("\nВведите VIN номер для проверки (Первая в спискке) ");
            string vinToCheck = Console.ReadLine();
            bool checkResult = cars[0].CheckVIN(vinToCheck);
            Console.WriteLine(checkResult);
            List<Employee> employees =
                [
                    new Employee()
                    {
                        Name = "Саня",
                        SecondName = "Саня",
                        ThirdName = "Саня",
                        Year = 2000,
                        Post = "уБОРЩИК"
                    },
                    new Employee()
                    {
                        Name = "Саня",
                        SecondName = "Саня",
                        ThirdName = "Саня",
                        Year = 2004,
                        Post = "St. Manager"
                    },
                    new Employee()
                    {
                        Name = "Саня",
                        SecondName = "Саня",
                        ThirdName = "Саня",
                        Year = 2010,
                        Post = "Ml. Manager"
                    },
                    new Employee()
                    {
                        Name = "Саня",
                        SecondName = "Саня",
                        ThirdName = "Саня",
                        Year = 2012,
                        Post = "Manager"
                    },
                    new Employee()
                    {
                        Name = "Sasavot",
                        SecondName = "Sasavot",
                        ThirdName = "Sasavot",
                        Year = 1980,
                        Post = "Deportament"
                    }
                ];
            Employee newEmployee = new();
            Console.WriteLine("Введите имя");
            newEmployee.Name = Console.ReadLine();

            Console.WriteLine("Вевите фамилию");
            newEmployee.SecondName = Console.ReadLine();

            Console.WriteLine("Введите отчествл");
            newEmployee.ThirdName = Console.ReadLine();

            Console.WriteLine("Введите год");
            newEmployee.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("введите Должность");
            newEmployee.Post = Console.ReadLine();
            employees.Add(newEmployee);

            Console.WriteLine("Введите имя сотрудника для удаления");
            string nameDel = Console.ReadLine().ToLower();

            Console.WriteLine("Введите фамилию сотрудника для удаления");
            string lastNameDel = Console.ReadLine().ToLower();

            Console.WriteLine("Введите отчество сотрудника для удаления");
            string thirdNameDel = Console.ReadLine().ToLower();

            Employee? employeeDel = employees.FirstOrDefault(x =>
            x.Name.ToLower() == nameDel &&
            x.SecondName.ToLower() == lastNameDel &&
            x.ThirdName.ToLower() == thirdNameDel);
            employees.Remove((Employee)employeeDel);
            employees = employees.OrderBy(e => e.SecondName).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Info);
            }


        }
    }
}