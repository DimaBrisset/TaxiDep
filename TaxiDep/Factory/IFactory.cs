

namespace TaxiDep
{
   interface IFactory
    {
        public  IProduction Create();
       // public static List<Car>cars=new List<Car>() { };

        public abstract int GetPrice();
        public abstract int GetFuelConsumption();
        public abstract int GetSpeed();
      





    }
}
