namespace DesignPattern.Strategy
{
    internal abstract class Vehicle
    {
        private IGoAlgorithm algorithm;

        public Vehicle()
        {
        }

        public void SetGoAlgorithm(IGoAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }

        public void Go()
        {
            this.algorithm.Go();
        }
    }
}