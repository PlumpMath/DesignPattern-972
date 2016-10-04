using System;

namespace DesignPattern.Strategy
{
    internal class GoByFlying : IGoAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Now I'm flying");
        }
    }
}