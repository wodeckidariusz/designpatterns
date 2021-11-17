using StrategyPattern.ClientObjects;
using StrategyPattern.ConcreteStrategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer colorfulPrinter = new Printer(new ColorfulPrinting(), "Print me in color pls!");
            colorfulPrinter.doPrinting();

            Printer blackAndWhitePrinter = new Printer(new BlackAndWhitePrinting(), "Print me in black and white pls!");
            blackAndWhitePrinter.doPrinting();

            Printer multiDimentionPrinter = new Printer(new MultiDimentionPrinting(), "Print me in 3D pls!");
            multiDimentionPrinter.doPrinting();
        }
    }
}
