using DemoInterpreter.GOLD_Logic.Model.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOLD;

namespace DemoInterpreter.GOLD_Logic.Model.Classes
{
    class Expression : INonTerminals
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
