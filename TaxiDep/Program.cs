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
           
            creator =new TrackFactory();
            IProduction truck1=creator.Create();
            IProduction truck2 = creator.Create();

            creator =new ElectroFactory();
            IProduction electro1=creator.Create();
            IProduction electro2 = creator.Create();

            List<IProduction> cars = new List<IProduction>() {  car1,truck1,electro1,};
            Test carservice = new Test(cars);





















            //  carservice.WithOutSortPrice();
          //  carservice.SortFuelByAscending();
           // carservice.SortFuelByDescending();


           //carservice.SortPriceByAscending();
          // carservice.SortPriceByDescending();

          

           //++  carservice.SortPriceByDescending();

           //++  carservice.PriceCar();

       
         //++    carservice.SortFuelByDescending();


          // carservice.SearchCarsSpeed( 100, 3000);

           













        }




    }
}


