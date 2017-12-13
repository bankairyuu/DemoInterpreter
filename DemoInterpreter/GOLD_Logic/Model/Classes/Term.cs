using DemoInterpreter.GOLD_Logic.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOLD;

namespace DemoInterpreter.GOLD_Logic.Model.Classes
{
    class Term : INonTerminals
    {
        public object Execute(GOLD.Reduction node)
        {
            throw new NotImplementedException();
        }

        public object Operation(object operand1, string operatorString, object operand2)
        {
            throw new NotImplementedException();
        }
    }
}
