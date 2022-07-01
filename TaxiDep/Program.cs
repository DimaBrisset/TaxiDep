using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;



namespace TaxiDep
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory creator = new GasFactory();  
            IProduction car1 = creator.Create();
            IProduction car2 = creator.Create();
            IProduction car3 = creator.Create();
            IProduction car4 = creator.Create();
            IProduction car5 = creator.Create();

            creator =new TrackFactory();
            IProduction truck=creator.Create();
            IProduction truck2 = creator.Create();

            creator =new ElectroFactory();
            IProduction electro=creator.Create();
            IProduction electro2 = creator.Create();

            List<IProduction> cars = new List<IProduction>() { car1,car2,car3,car4,car5};
                     
            
            Car carservice = new Car(cars);

            carservice.WithOutSortPrice();

            //   carservice.SortPriceByAscending();

            //    carservice.SortPriceByDescending();

            //  carservice.PriceCar();

            //   carservice.SortFuelByAscending();
            // carservice.SortFuelByDescending();


            carservice.SearchCarsSpeed( cars, 100, 200);

           













        }




    }
}


