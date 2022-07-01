using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaxiDep
{
    internal class Test
    {
        private readonly List<IProduction> _allCars;


        public Test(List<IProduction> cars)
        {

            _allCars = cars ?? new List<IProduction>();


        }


        public int GetCarsCount()
        {
            return _allCars.Count;

        }

        public void WithOutSortPrice()
        {
            Console.WriteLine($"Сейчас в сервисе {GetCarsCount()} машин");
            Console.WriteLine("Без Сортировки");

            for (int i = 0; i < _allCars.Count; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }
        }



        public void SortPriceByDescending()
        {

            Console.WriteLine("Цена по убывантю");
            _allCars.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
            _allCars.Reverse();
            for (int i = 0; i < _allCars.Count; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }
        }
        public void SortPriceByAscending()
        {

            Console.WriteLine("Цена по возрастанию");
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

            Console.WriteLine("Расход топлива Возрастанию");

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

            Console.WriteLine("Расход топлива убывантю");
            _allCars.Sort((x, y) => x.GetFuelConsumption().CompareTo(y.GetFuelConsumption()));
            _allCars.Reverse();
            for (int i = 0; i < _allCars.Count; i++)
            {
                Console.WriteLine(_allCars[i].ToString());
            }
        }


        public void PriceCar()
        {
            Console.WriteLine("Стоимость всех авто Авто");
            int sum = 0;
            for (int i = 0; i < _allCars.Count; i++)
            {
                sum = sum + _allCars[i].GetPrice();

            }
            Console.WriteLine(sum);
        }


        public void SearchCarsSpeed(int minPrice, int maxPrice)
        {

            Console.WriteLine("Скорость");
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
