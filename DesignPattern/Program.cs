using DesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StreetRacer streetRacer = new StreetRacer();
            Helicoper helicoper = new Helicoper();
            Jet jet = new Jet();

            streetRacer.Go();
            helicoper.Go();
            jet.Go();
        }
    }
}
