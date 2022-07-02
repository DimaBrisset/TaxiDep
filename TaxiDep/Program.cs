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

            creator = new ElectricalFactory();
            IProduction electro1 = creator.Create();
            IProduction electro2 = creator.Create();

            List<IProduction> cars = new List<IProduction>() {car1, car2, truck1, truck2, electro1, electro2};
            Calculation carCalculation = new Calculation(cars);


            UserMenu.UserChoices(carCalculation);
        }
    }
}