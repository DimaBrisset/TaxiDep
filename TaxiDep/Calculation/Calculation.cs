namespace TaxiDep.Calculation
{
    internal class Calculation
    {
        private readonly List<IProduction> _allCars;

        public Calculation(List<IProduction> cars)
        {
            _allCars = cars;
        }

        private int GetCarsCount()
        {
            return _allCars.Count;
        }

        public void WithOutSortPrice()
        {
            Console.WriteLine($"We have {GetCarsCount()} cars");


            foreach (IProduction cars in _allCars)
            {
                Console.WriteLine(cars.ToString());
            }
        }

        public void SortPriceByDescending()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            _allCars.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
            _allCars.Reverse();
            foreach (IProduction cars in _allCars)
            {
                Console.WriteLine(cars.ToString());
            }

            Console.ResetColor();
        }

        public void SortPriceByAscending()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _allCars.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
            _allCars.Reverse();
            _allCars.Reverse();
            foreach (IProduction cars in _allCars)
            {
                Console.WriteLine(cars.ToString());
            }

            Console.ResetColor();
        }

        public void SortFuelByAscending()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Car[] carsCopy = new Car[_allCars.Count];
            _allCars.Sort((x, y) => x.GetFuelConsumption().CompareTo(y.GetFuelConsumption()));
            _allCars.Reverse();
            _allCars.Reverse();
            for (int i = 0; i < carsCopy.Length; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }

            Console.ResetColor();
        }

        public void SortFuelByDescending()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _allCars.Sort((x, y) => x.GetFuelConsumption().CompareTo(y.GetFuelConsumption()));
            _allCars.Reverse();
            foreach (IProduction cars in _allCars)
            {
                Console.WriteLine(cars.ToString());
            }

            Console.ResetColor();
        }

        public void PriceCar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int sum = 0;
            foreach (IProduction cars in _allCars)
            {
                sum += cars.GetPrice();
            }

            Console.WriteLine(sum);
            Console.ResetColor();
        }

        public void SearchCarsSpeed(int minPrice, int maxPrice)
        {
            int carsCount = 0;
            Console.WriteLine("Search Auto speed");
            foreach (IProduction car in _allCars.Where(car => car.GetSpeed() >= minPrice && car.GetSpeed() <= maxPrice))
            {
                Console.WriteLine(car);
                carsCount++;
            }

            if (carsCount == 0)
            {
                Console.WriteLine("Auto Not Found\n");
            }
        }
    }
}