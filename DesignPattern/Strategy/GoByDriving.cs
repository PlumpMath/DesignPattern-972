using System;

namespace DesignPattern.Strategy
{
    internal class GoByDriving : IGoAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Now I'm driving");
        }
    }
}