using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterpreter.GOLD_Logic.Model.Interpreter
{
    interface INonTerminals
    {
        object Execute(GOLD.Reduction node);

        object Operation(object operand1, string operatorString, object operand2);
    }
}
