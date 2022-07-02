namespace TaxiDep
{
    internal interface IProduction
    {
        void Releasse();
        string GetId();
        string GetModel();
        int GetPrice();
        int GetFuelConsumption();
        int GetSpeed();
    }
}