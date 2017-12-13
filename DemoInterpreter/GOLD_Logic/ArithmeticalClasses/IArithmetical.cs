using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterpreter.GOLD_Logic.ArithmeticalClasses
{
    interface IArithmetical
    {
        bool Equal(object operand1, object operand2);
        bool NotEqual(object operand1, object operand2);
        bool GreaterThan(object operand1, object operand2);
        bool LessThan(object operand1, object operand2);
        bool GreaterOrEqual(object operand1, object operand2);
        bool LessOrEqual(object operand1, object operand2);
        bool And(object operand1, object operand2);
        bool Or(object operand1, object operand2);

        object Add(object operand1, object operand2);
        object Substract(object operand1, object operand2);
        object Multiply(object operand1, object operand2);
        object Divide(object operand1, object operand2);

        object Negate(object operand1);
    }
}
