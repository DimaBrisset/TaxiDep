
namespace TaxiDep
{
    internal class Car : IProduction
    {
        
        private string _id="";
        private string _model="";
        private int _price;
        private int _fuelConsumption;
        private FuelType _fuelType;
        private int _speed;

      
        

        public Car(string id, string model, int price, int fuelConsumption, FuelType fuelType, int speed)
        {
            _id = id;
            _model = model;
            _price = price;
            _fuelConsumption = fuelConsumption;
            _fuelType = FuelType.Gas;
            _speed = speed;
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
