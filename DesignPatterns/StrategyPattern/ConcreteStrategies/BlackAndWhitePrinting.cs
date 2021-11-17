using StrategyPattern.AbstractStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ConcreteStrategies
{
    class BlackAndWhitePrinting : IPrinting
    {
        public string performSpecificPrinting(string textToPrint)
        {
            return $"Black and white text '{textToPrint}' printed successfully!";
        }
    }
}
