using StrategyPattern.AbstractStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ConcreteStrategies
{
    class ColorfulPrinting : IPrinting
    {
        public string performSpecificPrinting(string textToPrint)
        {
            return $"Colorful text '{textToPrint}' printed successfully!";
        }
    }
}
