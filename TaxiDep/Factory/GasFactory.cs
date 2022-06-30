
namespace TaxiDep
{
    internal class GasFactory : IFactorle
    {


        private List<Car> _car;
       




        private string _id;
        public string _model;
       public int _price;
        private int _fuelConsumption;
        private FuelType _fuelType;
        private int _speed;


        public GasFactory(string id, string model, int price, int fuelConsumption, FuelType fuelType, int speed)
        {
            _id = id;
            _model = model;
            _price = price;
            _fuelConsumption = fuelConsumption;
            _fuelType = fuelType;
            _speed = speed;


        }

        public GasFactory()
        {
            _id = Guid.NewGuid().ToString();
            _model = "NO MODEL";
            _price = 0;
            _fuelConsumption = 0;
            _fuelType = 0;
            _speed = 0;
        }


        public IProduction Create()
        {


            _id = CarsParametrs.Id();
            _model = CarsParametrs.ModelsOrdinary();
            _price = CarsParametrs.Price();
            _fuelConsumption = CarsParametrs.Consumption();
            _fuelType = FuelType.Gas;
            _speed = CarsParametrs.Speed();

            Car car = new Car(_id, _model, _price, _fuelConsumption, _fuelType, _speed);
            return car;


        }

      

        public int GetPrice()
        {
            return _price;
        }
        public int GetFuelConsumption()
        {
            return _fuelConsumption;
        }
        public  int GetSpeed()
        {
            return _speed;
        }





        public GasFactory(List<Car> cars)
        {
            _car = cars;
        }

        public int GetCarsCount()
        {
            return _car.Count;
        }


        public void Ascending()
        {

            Console.WriteLine($"Сейчас в сервисе {GetCarsCount()} машин");

            Car[] carsCopy = new Car[_car.Count];
            _car.CopyTo(carsCopy, 0);
            _car.Sort((x, y) => x._price.CompareTo(y._price));
            for (int i = 0; i < carsCopy.Length; i++)
            {
                Console.WriteLine($"Машина номер {i + 1}.{carsCopy[i]._model},{_car[i]._price}");
            }
        }




















    }
}
