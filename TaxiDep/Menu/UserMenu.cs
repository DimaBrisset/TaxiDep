namespace TaxiDep
{
    internal static class UserMenu
    {
        public static void UserChoices(Calculation carService)
        {
            ShowMenu();

            var choices = Console.ReadLine();

            while (choices != "1" || choices != "2" || choices != "3" || choices != "4" || choices != "5" || choices != "6" || choices != "7" || choices != "0")
            {
                switch (choices)
                {
                    case "1":
                        Console.WriteLine("Show all AUTO");
                        carService.WithOutSortPrice();
                        break;
                    case "2":
                        Console.WriteLine("Cost of all cars");
                        carService.PriceCar();
                        break;

                    case "3":
                        Console.WriteLine("Sort Fuel By Ascending");
                        carService.SortFuelByAscending();
                        break;
                    case "4":
                        Console.WriteLine("Sort Fuel By Descending");

                        carService.SortFuelByDescending();
                        break;
                    case "5":
                        Console.WriteLine("Sort Price By Ascending");
                        carService.SortPriceByAscending();
                        break;
                    case "6":
                        Console.WriteLine("Sort Price By Descending");
                        carService.SortPriceByDescending();
                        break;
                    case "7":
                        Console.WriteLine("Search Cars Speed");
                        carService.SearchCarsSpeed(UserInputNumber(), UserInputNumber());
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }

                ShowMenu();

                choices = Console.ReadLine();
                // Console.Clear();
            }
          
        }

        private static int UserInputNumber()
        {
            Console.Write("InputSpeed: ");
            string? checkStated = Console.ReadLine();
            bool isSuccessful = int.TryParse(checkStated, out int staded);
            while (!isSuccessful)
            {
                Console.WriteLine("Error");
                Console.Write("InputSpeed: ");
                checkStated = Console.ReadLine();
                isSuccessful = int.TryParse(checkStated, out staded);
            }

            return staded;
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Button # 1, Show all AUTO");
            Console.WriteLine("Button # 2, Сost of all cars");
            Console.WriteLine("Button # 3, Sort Fuel By Ascending");
            Console.WriteLine("Button # 4, Sort Fuel By Descending");
            Console.WriteLine("Button # 5, Sort Price By Ascending");
            Console.WriteLine("Button # 6, Sort Price By Descending");
            Console.WriteLine("Button # 7, Search Cars Speed");
            Console.WriteLine("Button # 0, Exit");
        }
    }
}