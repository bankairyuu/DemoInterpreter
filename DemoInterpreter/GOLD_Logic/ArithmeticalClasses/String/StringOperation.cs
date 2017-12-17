using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterpreter.GOLD_Logic.ArithmeticalClasses.String
{
    class StringOperation : IArithmetical
    {
        public object Add(object operand1, object operand2)
        {
            return operand1.ToString().Replace("\"", "") + operand2.ToString().Replace("\"", "");
        }

        public bool And(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public object Divide(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public bool Equal(object operand1, object operand2)
        {
            return operand1.ToString() == operand2.ToString() ? true : false;
        }

        public bool GreaterOrEqual(object operand1, object operand2)
        {
            return operand1.ToString().Length >= operand2.ToString().Length ? true : false;
        }

        public bool GreaterThan(object operand1, object operand2)
        {
            return operand1.ToString().Length > operand2.ToString().Length ? true : false;
        }

        public bool LessOrEqual(object operand1, object operand2)
        {
            return operand1.ToString().Length <= operand2.ToString().Length ? true : false;
        }

        public bool LessThan(object operand1, object operand2)
        {
            return operand1.ToString().Length < operand2.ToString().Length ? true : false;
        }

        public object Multiply(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public object Negate(object operand1)
        {
            throw new NotSupportedException();
        }

        public bool NotEqual(object operand1, object operand2)
        {
            return operand1.ToString() != operand2.ToString() ? true : false;
        }

        public bool Or(object operand1, object operand2)
        {
            throw new NotSupportedException();
        }

        public object Substract(object operand1, object operand2)
        {
            return operand1.ToString().Replace("\"", "").Replace(operand2.ToString().Replace("\"", ""), "");
        }
    }
}
