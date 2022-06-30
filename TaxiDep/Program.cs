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
            IProduction car = creator.Create();
            IProduction car2 = creator.Create();
                     

            creator =new TrackFactory();
            IProduction truck=creator.Create();
            IProduction truck2 = creator.Create();

            creator =new ElectroFactory();
            IProduction electro=creator.Create();
            IProduction electro2 = creator.Create();

            List<IProduction> cars = new List<IProduction>() { car,car2 };

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }


         GasFactory carservice = new GasFactory(cars);
            carservice.Ascending();










            //Console.WriteLine(car);
            //Console.WriteLine(car2);
            //Console.WriteLine(bas);
            //Console.WriteLine(bas2);
            //Console.WriteLine(electro);
            //Console.WriteLine(electro2);







        }
    }
}


