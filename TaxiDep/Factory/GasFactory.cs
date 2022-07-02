﻿namespace TaxiDep
{
    internal class GasFactory : IFactory
    {
        private string _id;
        private string _model;
        private int _price;
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
    }
}