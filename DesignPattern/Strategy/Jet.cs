namespace DesignPattern.Strategy
{
    internal class Jet : Vehicle
    {
        public Jet()
        {
            SetGoAlgorithm(new GoByFlyingFast());
        }
    }
}