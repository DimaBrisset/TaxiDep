namespace TaxiDep
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory creator = new GasFactory();
            IProduction car1 = creator.Create();
            IProduction car2 = creator.Create();

            creator = new TrackFactory();
            IProduction truck1 = creator.Create();
            IProduction truck2 = creator.Create();

            creator = new ElectroFactory();
            IProduction electro1 = creator.Create();
            IProduction electro2 = creator.Create();

            List<IProduction> cars = new List<IProduction>() {car1, car2, truck1, truck2, electro1, electro2};
            Calculation carservice = new Calculation(cars);


            bool exit = false;
            do
            {
                Console.WriteLine("Button # 1, Show all AUTO");
                Console.WriteLine("Button # 2, Сost of all cars");
                Console.WriteLine("Button # 3, Sort Fuel By Ascending");
                Console.WriteLine("Button # 4, Sort Fuel By Descending");
                Console.WriteLine("Button # 5, Sort Price By Ascending");
                Console.WriteLine("Button # 6, Sort Price By Descending");
                Console.WriteLine("Button # 7, Search Cars Speed");
                Console.WriteLine("Button # 0, Exit");


                var choices = (Console.ReadLine());

                switch (choices)
                {
                    case "1":
                        Console.WriteLine("Show all AUTO");
                        carservice.WithOutSortPrice();
                        break;
                    case "2":
                        Console.WriteLine("Cost of all cars");
                        carservice.PriceCar();
                        break;

                    case "3":
                        Console.WriteLine("Sort Fuel By Ascending");
                        carservice.SortFuelByAscending();
                        break;
                    case "4":
                        Console.WriteLine("Sort Fuel By Descending");

                        carservice.SortFuelByDescending();
                        break;
                    case "5":
                        Console.WriteLine("Sort Price By Ascending");
                        carservice.SortPriceByAscending();
                        break;
                    case "6":
                        Console.WriteLine("Sort Price By Descending");
                        carservice.SortPriceByDescending();
                        break;
                    case "7":
                        Console.WriteLine("Search Cars Speed");
                        carservice.SearchCarsSpeed(UserInputNumber(), UserInputNumber());
                        break;

                    case "0":
                        exit = true;
                        break;
                }
            } while (!exit);


            static int UserInputNumber()
            {
                int staded;
                Console.Write("Input number: ");
                var checkStaded = Console.ReadLine();
                bool isSuccessful = int.TryParse(checkStaded, out staded);
                while (!isSuccessful)
                {
                    Console.WriteLine("Error");
                    Console.Write("Input number: ");
                    checkStaded = Console.ReadLine();
                    isSuccessful = int.TryParse(checkStaded, out staded);
                }

                return staded;
            }
        }
    }
}