using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDep
{
    internal class Electro: IProduction
    {
        private string _id;
        private string _model;
        private int _price;
        private int _fuelConsumption;
        private FuelType _fuelType;
        private int _speed;





        public Electro(string id, string model, int price, int fuelConsumption, FuelType fuelType, int speed)
        {
            _id = id;
            _model = model;
            _price = price;
            _fuelConsumption = fuelConsumption;
            _fuelType = FuelType.Battery;
            _speed = speed;
        }




        public void Releasse()
        {
            var car = new Electro(_id, _model, _price, _fuelConsumption, _fuelType, _speed);

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
