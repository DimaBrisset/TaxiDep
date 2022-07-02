namespace TaxiDep.OptionsCars

{
    public static class CarsOptions
    {
        public static string Battery()
        {
            string[] battery = new string[] {"LiIon", "AluminumIon", " LithiumSulfur", " MetalAir"};
            Random random = new();
            var choiceBattery = battery[random.Next(0, battery.Length)];

            return choiceBattery;
        }

        public static string ModelsOrdinary()
        {
            Random random = new();
            string[] models = new string[]
                {" Audi", "Acura", "  AlfaRomeo", " Bentley", "Toyota", "Suzuki", "Lexus", " Mazda"};
            var choiceModels = models[random.Next(0, models.Length)];
            return choiceModels;
        }

        public static string ModelsTruck()
        {
            Random random = new();
            string[] models = new string[]
            {
                " Audi(Truck)", "Acura(Truck)", "  AlfaRomeo(Truck)", " Bentley(Truck)", "Toyota(Truck)",
                "Suzuki(Truck)", "Lexus(Truck)", " Mazda(Truck)"
            };
            var choiceModels = models[random.Next(0, models.Length)];
            return choiceModels;
        }

        public static string ModelsElectrical()
        {
            Random random = new();
            string[] models = new string[]
            {
                " Audi(Electrical)", "Acura(Electrical)", "  AlfaRomeo(Electrical)", " Bentley(Electrical)",
                "Toyota(Electrical)",
                "Suzuki(Electrical)", "Lexus(Electrical)", " Mazda(Electrical)"
            };
            var choiceModels = models[random.Next(0, models.Length)];
            return choiceModels;
        }

        public static string ModelsCar()
        {
            Random random = new();
            string[] models = new string[]
                {" Audi", "Acura", "  AlfaRomeo", " Bentley", "Toyota", "Suzuki", "Lexus", " Mazda"};
            var choiceModels = models[random.Next(0, models.Length)];
            return choiceModels;
        }

        public static int Price()
        {
            int[] price = new int[] {1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000};
            Random random = new();
            var choicePrice = price[random.Next(0, price.Length)];
            return choicePrice;
        }

        public static int Consumption()
        {
            Random random = new();
            var fuel = random.Next(5, 15);
            return fuel;
        }

        public static int Speed()
        {
            Random random = new();
            var speed = random.Next(150, 500);
            return speed;
        }

        public static string Id()
        {
            return Guid.NewGuid().ToString();
        }
    }
}