using TaxiDep.OptionsCars;

namespace TaxiDep
{
    internal class Truck : IProduction
    {
        private readonly string _id;
        private readonly string _model;
        private readonly int _price;
        private readonly int _fuelConsumption;
        private readonly FuelType _fuelType;
        private readonly int _speed;

        public Truck(string id, string model, int price, int fuelConsumption, FuelType fuelType, int speed)
        {
            _id = id;
            _model = model;
            _price = price;
            _fuelConsumption = fuelConsumption;
            _fuelType = fuelType;
            _speed = speed;
        }

        public void Release()
        {
            _ = new Truck(_id, _model, _price, _fuelConsumption, _fuelType, _speed);
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

        public override string ToString()
        {
            return $"ID: {_id}\n" +
                $"Model: {_model}\n" +
                $"Price: {_price}\n" +
                $"Fuel Consumption: {_fuelConsumption}\n" +
                $"Fuel Type: {_fuelType}\n" +
                $"Speed: {_speed}\n";
        }
    }
}