using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterpreter.GOLD_Logic.ArithmeticalClasses.Numeric
{
    class NumericalOperation : IArithmetical
    {
        public object Add(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) + Convert.ToInt32(operand2);
        }

        public bool And(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public object Divide(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) / Convert.ToInt32(operand2);
        }

        public bool Equal(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) == Convert.ToInt32(operand2) ? true : false;
        }

        public bool GreaterOrEqual(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) >= Convert.ToInt32(operand2) ? true : false;
        }

        public bool GreaterThan(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) > Convert.ToInt32(operand2) ? true : false;
        }

        public bool LessOrEqual(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) <= Convert.ToInt32(operand2) ? true : false;
        }

        public bool LessThan(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) < Convert.ToInt32(operand2) ? true : false;
        }

        public object Multiply(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) * Convert.ToInt32(operand2);
        }

        public object Negate(object operand1)
        {
            throw new NotSupportedException();
        }

        public bool NotEqual(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) != Convert.ToInt32(operand2) ? true : false;
        }

        public bool Or(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public object Substract(object operand1, object operand2)
        {
            return Convert.ToInt32(operand1) - Convert.ToInt32(operand2);
        }
    }
}
