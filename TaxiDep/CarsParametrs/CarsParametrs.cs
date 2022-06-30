namespace TaxiDep

{
    public class CarsParametrs
    {

        public static string Battary()
        {
            string[] battary = new string[] { "LiIon", "AluminumIon", " LithiumSulfur", " MetalAir" };
            Random random = new Random();
            var choiceBattary = battary[random.Next(0, battary.Length)];

            return choiceBattary;
        }

        public static string ModelsOrdinary()
        {
            Random random = new Random();
            string[] models = new string[]
                {" Audi", "Acura", "  AlfaRomeo", " Bentley", "Toyota", "Suzuki", "Lexus", " Mazda"};
            var choiceModels = models[random.Next(0, models.Length)];
            return choiceModels;
        }


        public static string ModelsTruck()
        {
            Random random = new Random();
            string[] models = new string[]
                {" Audi(Truck)", "Acura(Truck)", "  AlfaRomeo(Truck)", " Bentley(Truck)", "Toyota(Truck)", "Suzuki(Truck)", "Lexus(Truck)", " Mazda(Truck)"};
            var choiceModels = models[random.Next(0, models.Length)];
            return choiceModels;
        }

        public static string ModelsElectro()
        {
            Random random = new Random();
            string[] models = new string[]
                {" Audi(Electro)", "Acura(Electro)", "  AlfaRomeo(Electro)", " Bentley(Electro)", "Toyota(Electro)", "Suzuki(Electro)", "Lexus(Electro)", " Mazda(Electro)"};
            var choiceModels = models[random.Next(0, models.Length)];
            return choiceModels;
        }


        public static string ModelsCar()
        {
            Random random = new Random();
            string[] models = new string[]
                {" Audi", "Acura", "  AlfaRomeo", " Bentley", "Toyota", "Suzuki", "Lexus", " Mazda"};
            var choiceModels = models[random.Next(0, models.Length)];
            return choiceModels;
        }




        public static int Price()
        {

            int[] price = new int[] { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000 };
            Random random = new Random();
            var choicePrice = price[random.Next(0, price.Length)];
            return choicePrice;

        }



        public static int Consumption()
        {
            Random random = new Random();
            var fuel = random.Next(5, 15);
            return fuel;
        }

        public static int Speed()
        {
            Random random = new Random();
            var speed = random.Next(150, 500);
            return speed;
        }

        public static string Id()
        {
            return Guid.NewGuid().ToString();
        }
    }
}