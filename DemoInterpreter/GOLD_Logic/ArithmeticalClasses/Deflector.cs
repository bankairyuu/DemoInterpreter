using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterpreter.GOLD_Logic.ArithmeticalClasses
{
    public static class Deflector
    {
        /// <summary>
        /// 0 - Error , 1 - int , 2 - string, 3 - bool
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns></returns>
        private static int TypeCheck(object operand1, object operand2)
        {
            if (operand1.GetType() == typeof(int)
                &&
                operand2.GetType() == typeof(int))
            {
                return 1;
            }
            else if (operand1.GetType() == typeof(string)
                     &&
                     operand2.GetType() == typeof(string))
            {
                return 2;
            }
            else if (operand1.GetType() == typeof(bool)
                     &&
                     operand2.GetType() == typeof(bool))
            {
                return 3;
            }

            return 0;
        }

        public static object Add(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static bool And(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static object Divide(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static bool Equal(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static bool GreaterOrEqual(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static bool GreaterThan(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static bool LessOrEqual(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static bool LessThan(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static object Multiply(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static object Negate(object operand1)
        {
            throw new NotImplementedException();
        }

        public static bool NotEqual(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static bool Or(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }

        public static object Substract(object operand1, object operand2)
        {
            throw new NotImplementedException();
        }
    }
}
