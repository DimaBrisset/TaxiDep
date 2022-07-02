namespace TaxiDep
{
    internal class ElectroFactory : IFactory
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

        public ElectroFactory(string id, string model, int price, int fuelConsumption, FuelType fuelType, int speed)
        {
            _id = id;
            _model = model;
            _price = price;
            _fuelConsumption = fuelConsumption;
            _fuelType = fuelType;
            _speed = speed;
        }

        public ElectroFactory()
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
            _model = CarsParametrs.ModelsElectro();
            _price = CarsParametrs.Price();
            _fuelConsumption = CarsParametrs.Consumption();
            _fuelType = FuelType.Deisel;
            _speed = CarsParametrs.Speed();

            Electro car = new Electro(_id, _model, _price, _fuelConsumption, _fuelType, _speed);
            return car;
        }
    }
}