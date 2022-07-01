
namespace TaxiDep
{
    internal class Car : IProduction
    {

        
        public List<IProduction> _car;
       
     


        private string _id="";
        private string _model="";
        private int _price;
        private int _fuelConsumption;
        private FuelType _fuelType;
        private int _speed;

       public Car(List<IProduction> cars)
        {
         
                _car = cars;
           
        }

        

        public Car(string id, string model, int price, int fuelConsumption, FuelType fuelType, int speed)
        {
            _id = id;
            _model = model;
            _price = price;
            _fuelConsumption = fuelConsumption;
            _fuelType = FuelType.Gas;
            _speed = speed;
        }

   


        public int GetCarsCount()
        {
            return _car.Count;

        }

        public void WithOutSortPrice()
        {
            Console.WriteLine($"Сейчас в сервисе {GetCarsCount()} машин");
            Console.WriteLine("Без Сортировки");

            for (int i = 0; i < _car.Count; i++)
            {
                Console.WriteLine(_car[i].ToString());
            }
        }
        public void SortPriceByDescending()
        {
           
            Console.WriteLine("Цена по убывантю");
            _car.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
            _car.Reverse();
            for (int i = 0; i < _car.Count; i++)
            {
                Console.WriteLine(_car[i].ToString());
            }
        }

        

        public void SortPriceByAscending()
        {
                      
            Console.WriteLine("Цена по возрастанию");
            Car[] carsCopy = new Car[_car.Count];
            _car.CopyTo(carsCopy, 0);
            _car.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
            for (int i = 0; i < carsCopy.Length; i++)
            {
                Console.WriteLine(_car[i].ToString());
            }

        }

        public void SortFuelByAscending()
        {

            Console.WriteLine("Расход топлива по возрастанию");
            Car[] carsCopy = new Car[_car.Count];
            _car.CopyTo(carsCopy, 0);
            _car.Sort((x, y) => x.GetFuelConsumption().CompareTo(y.GetFuelConsumption()));
            for (int i = 0; i < carsCopy.Length; i++)
            {
                Console.WriteLine(_car[i].ToString());
            }

        }

        public void SortFuelByDescending()
        {
           
            Console.WriteLine("Расход топлива убывантю");
            _car.Sort((x, y) => x.GetFuelConsumption().CompareTo(y.GetFuelConsumption()));
            _car.Reverse();
            for (int i = 0; i < _car.Count; i++)
            {
                Console.WriteLine(_car[i].ToString());
            }
        }


        public void PriceCar()
        {
            Console.WriteLine("Стоимость всех авто Авто");
            int sum = 0;
            for (int i = 0; i < _car.Count; i++)
            {
                sum = sum + _car[i].GetPrice();

            }
            Console.WriteLine(sum);
        }


        internal List<Car> SearchCarsSpeed(List<IProduction> cars, int minPrice, int maxPrice)
        {
            List<Car> carSelect = new List<Car>();
            Console.WriteLine("Скорость");
            foreach (Car car in cars)
            {
                if (car.GetSpeed() >= minPrice && car.GetSpeed() <= maxPrice)
                {
                    carSelect.Add(car);
                    Console.WriteLine(car);
                }
               
             

            }



            return carSelect;
        }



      






        public override string ToString()
        {
            return $"ID: {_id}\n" +
                $"Model: {_model}\n" +
                $"Price: {_price}\n" +
                $"Fuel Consumption: {_fuelConsumption}\n" +
                $"Fuel Type: {_fuelType}\n" +
                $"Speed: {_speed}\n";
        }


        public void Releasse()
        {
            var car = new Car(_id, _model, _price, _fuelConsumption, _fuelType, _speed);
        }

        public int GetPrice()
        {
            return _price;
        }
        public string GetModel()
        {
            return _model;
        }

        public int GetFuelConsumption()
        {
            return _fuelConsumption;
        }
        public int GetSpeed()
        {
            return _speed;
        }

        public string GetId()
        {
            return _id;
        }


    }
}
