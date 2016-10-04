namespace DesignPattern.Strategy
{
    internal class StreetRacer : Vehicle
    {
        public StreetRacer()
        {
            SetGoAlgorithm(new GoByDriving());
        }
    }
}