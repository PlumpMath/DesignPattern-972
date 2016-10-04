using System;

namespace DesignPattern.Strategy
{
    internal class GoByFlyingFast : IGoAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Now I'm flying fast");
        }
    }
}