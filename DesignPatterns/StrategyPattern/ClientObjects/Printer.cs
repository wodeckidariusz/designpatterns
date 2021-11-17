using StrategyPattern.AbstractStrategies;
using System;

namespace StrategyPattern.ClientObjects
{
    class Printer
    {
        private IPrinting _printStrategy;
        private string _textToPrint;

        public Printer() { }

        public Printer(IPrinting printStrategy, string textToPrint)
        {
            this._printStrategy = printStrategy;
            this._textToPrint = textToPrint;
        }

        public void doPrinting()
        {
            string retVal = this._printStrategy.performSpecificPrinting(this._textToPrint);
            Console.WriteLine(retVal);
        }
    }
}
