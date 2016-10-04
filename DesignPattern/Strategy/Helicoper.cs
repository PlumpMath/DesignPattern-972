namespace DesignPattern.Strategy
{
    internal class Helicoper : Vehicle
    {
        public Helicoper()
        {
            SetGoAlgorithm(new GoByFlying());
        }
    }
}