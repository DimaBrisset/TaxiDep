using TaxiDep.Factory;
using TaxiDep.Menu;

namespace TaxiDep
{
    internal static class Program
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
            IProduction electric1 = creator.Create();
            IProduction electric2 = creator.Create();

            List<IProduction> cars = new() {car1, car2, truck1, truck2, electric1, electric2};
            Calculation.Calculation carCalculation = new(cars);


            UserMenu.UserChoices(carCalculation);
        }
    }
}