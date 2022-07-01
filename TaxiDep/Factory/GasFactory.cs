
namespace TaxiDep
{
    internal class GasFactory : IFactory
    {


        private string _id;
        private string _model;
        private int _price;
        private int _fuelConsumption;
        private FuelType _fuelType;
        private int _speed;

        public string Id => _id;
        public string Model => _model;
        public int Price => _price;
        public int FuelConsumption => _fuelConsumption;
        public int Speed => _speed;

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

      


       
    }
























}

