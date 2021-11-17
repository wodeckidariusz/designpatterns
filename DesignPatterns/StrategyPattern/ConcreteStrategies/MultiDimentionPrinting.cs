using StrategyPattern.AbstractStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ConcreteStrategies
{
    class MultiDimentionPrinting : IPrinting
    {
        public string performSpecificPrinting(string textToPrint)
        {
            return $"3D text '{textToPrint}' printed successfully!";
        }
    }
}
