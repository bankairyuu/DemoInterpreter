using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterpreter.GOLD_Logic.ArithmeticalClasses.Boolean
{
    class BooleanOperation : IArithmetical
    {
        public object Add(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public bool And(object operand1, object operand2)
        {
            return Convert.ToBoolean(operand1) && Convert.ToBoolean(operand2) ? true : false;
        }

        public object Divide(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public bool Equal(object operand1, object operand2)
        {
            return Convert.ToBoolean(operand1) == Convert.ToBoolean(operand2) ? true : false;
        }

        public bool GreaterOrEqual(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public bool GreaterThan(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public bool LessOrEqual(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public bool LessThan(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public object Multiply(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public object Negate(object operand1)
        {
            return !Convert.ToBoolean(operand1);
        }

        public bool NotEqual(object operand1, object operand2)
        {
            return Convert.ToBoolean(operand1) != Convert.ToBoolean(operand2) ? true : false;
        }

        public bool Or(object operand1, object operand2)
        {
            return Convert.ToBoolean(operand1) || Convert.ToBoolean(operand2) ? true : false;
        }

        public object Substract(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }
    }
}
