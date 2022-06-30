﻿
namespace TaxiDep
{
    internal class Truck : IProduction
    {
        private string _id;
        private string _model;
        private int _price;
        private int _fuelConsumption;
        private FuelType _fuelType;
        private int _speed;





        public Truck(string id, string model, int price, int fuelConsumption, FuelType fuelType, int speed)
        {
            _id = id;
            _model = model;
            _price = price;
            _fuelConsumption = fuelConsumption;
            _fuelType = FuelType.Deisel;
            _speed = speed;
        }



    

        public void Releasse()
        {
            var car = new Truck(_id, _model, _price, _fuelConsumption, _fuelType, _speed);

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
