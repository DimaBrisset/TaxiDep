

namespace TaxiDep
{
    internal class TrackFactory: IFactory
    {

        private string _id;
        private string _model;
        private int _price;
        private int _fuelConsumption;
        private FuelType _fuelType;
        private int _speed;


        public TrackFactory(string id, string model, int price, int fuelConsumption, FuelType fuelType, int speed)
        {
            _id = id;
            _model = model;
            _price = price;
            _fuelConsumption = fuelConsumption;
            _fuelType = fuelType;
            _speed = speed;


        }

        public TrackFactory()
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
            _model = CarsParametrs.ModelsTruck();
            _price = CarsParametrs.Price();
            _fuelConsumption = CarsParametrs.Consumption();
            _fuelType = FuelType.Deisel;
            _speed = CarsParametrs.Speed();

             Truck car = new Truck(_id, _model, _price, _fuelConsumption, _fuelType, _speed);
            return car;


        }




        public  int GetPrice()
        {
            return _price;
        }
        public  int GetFuelConsumption()
        {
            return _fuelConsumption;
        }
        public  int GetSpeed()
        {
            return _speed;
        }



    }
}
