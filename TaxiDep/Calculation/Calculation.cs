namespace TaxiDep
{
    internal class Calculation
    {
        private readonly List<IProduction> _allCars;

        public Calculation(List<IProduction> cars)
        {
            _allCars = cars ?? new List<IProduction>();
        }

        public int GetCarsCount()
        {
            return _allCars.Count;
        }

        public void WithOutSortPrice()
        {
            Console.WriteLine($"We have {GetCarsCount()} cars");


            for (int i = 0; i < _allCars.Count; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }
        }

        public void SortPriceByDescending()
        {
            _allCars.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
            _allCars.Reverse();
            for (int i = 0; i < _allCars.Count; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }
        }

        public void SortPriceByAscending()
        {
            _allCars.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
            _allCars.Reverse();
            _allCars.Reverse();
            for (int i = 0; i < _allCars.Count; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }
        }

        public void SortFuelByAscending()
        {
            Car[] carsCopy = new Car[_allCars.Count];
            _allCars.Sort((x, y) => x.GetFuelConsumption().CompareTo(y.GetFuelConsumption()));
            _allCars.Reverse();
            _allCars.Reverse();
            for (int i = 0; i < carsCopy.Length; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }
        }

        public void SortFuelByDescending()
        {
            _allCars.Sort((x, y) => x.GetFuelConsumption().CompareTo(y.GetFuelConsumption()));
            _allCars.Reverse();
            for (int i = 0; i < _allCars.Count; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }
        }

        public void PriceCar()
        {
            int sum = 0;
            for (int i = 0; i < _allCars.Count; i++)
            {
                sum = sum + _allCars[i].GetPrice();
            }

            Console.WriteLine(sum);
        }

        public void SearchCarsSpeed(int minPrice, int maxPrice)
        {
            Console.WriteLine("Search Auto speed");
            foreach (var car in _allCars)
            {
                if (car.GetSpeed() >= minPrice && car.GetSpeed() <= maxPrice)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}