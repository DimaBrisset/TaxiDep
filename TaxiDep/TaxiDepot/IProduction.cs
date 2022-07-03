namespace TaxiDep
{
    internal interface IProduction
    {
        void Release();
        string GetId();
        string GetModel();
        int GetPrice();
        int GetFuelConsumption();
        int GetSpeed();
    }
}