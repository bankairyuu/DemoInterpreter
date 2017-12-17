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
            try
            {
                Convert.ToInt32(operand1);
                Convert.ToInt32(operand2);
                return 1;
            }
            catch (Exception)
            {
                try
                {
                    Convert.ToBoolean(operand1);
                    Convert.ToBoolean(operand2);
                    return 3;
                }
                catch (Exception)
                {
                    return 2;
                }
            }
        }

        public static object OperationResolver(object operand1, string operatorString, object operand2)
        {
            switch (operatorString)
            {
                case "=":
                case "==":
                    return Equal(operand1, operand2);
                case "!=":
                    return NotEqual(operand1, operand2);
                case "&&":
                    return And(operand1, operand2);
                case "||":
                    return Or(operand1, operand2);
                case "<":
                    return LessThan(operand1, operand2);
                case ">":
                    return GreaterThan(operand1, operand2);
                case "<=":
                    return LessOrEqual(operand1, operand2);
                case ">=":
                    return GreaterOrEqual(operand1, operand2);
                case "+":
                    return Add(operand1, operand2);
                case "-":
                    return Substract(operand1, operand2);
                case "*":
                    return Multiply(operand1, operand2);
                case "/":
                    return Divide(operand1, operand2);
                case "!":
                    return Negate(operand1);
                default:
                    break;
            }
            return null;
        }

        public static object Add(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    Add(operand1, operand2);
                case 2: return new String.StringOperation().        Add(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      Add(operand1, operand2);
                default: throw new Exception("\nError in operation \"Add\" between:\n" +
                    "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
                    "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static bool And(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    And(operand1, operand2);
                case 2: return new String.StringOperation().        And(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      And(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"And\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static object Divide(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    Divide(operand1, operand2);
                case 2: return new String.StringOperation().        Divide(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      Divide(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"Divide\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static bool Equal(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    Equal(operand1, operand2);
                case 2: return new String.StringOperation().        Equal(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      Equal(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"Equal\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static bool GreaterOrEqual(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    GreaterOrEqual(operand1, operand2);
                case 2: return new String.StringOperation().        GreaterOrEqual(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      GreaterOrEqual(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"GreaterOrEqual\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static bool GreaterThan(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    GreaterThan(operand1, operand2);
                case 2: return new String.StringOperation().        GreaterThan(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      GreaterThan(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"GreaterThan\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static bool LessOrEqual(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    LessOrEqual(operand1, operand2);
                case 2: return new String.StringOperation().        LessOrEqual(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      LessOrEqual(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"LessOrEqual\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static bool LessThan(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    LessThan(operand1, operand2);
                case 2: return new String.StringOperation().        LessThan(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      LessThan(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"LessThan\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static object Multiply(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    Multiply(operand1, operand2);
                case 2: return new String.StringOperation().        Multiply(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      Multiply(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"Multiply\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static object Negate(object operand1)
        {
            switch (TypeCheck(operand1, operand1))
            {
                case 1: return new Numeric.NumericalOperation().    Negate(operand1);
                case 2: return new String.StringOperation().        Negate(operand1);
                case 3: return new Boolean.BooleanOperation().      Negate(operand1);
                default:
                    throw new Exception("\nError in operation \"Negate\" of:\n" +
               "Type " + operand1.GetType() + " : " + operand1);
            }
        }

        public static bool NotEqual(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    NotEqual(operand1, operand2);
                case 2: return new String.StringOperation().        NotEqual(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      NotEqual(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"NotEqual\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static bool Or(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    Or(operand1, operand2);
                case 2: return new String.StringOperation().        Or(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      Or(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"Or\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }

        public static object Substract(object operand1, object operand2)
        {
            switch (TypeCheck(operand1, operand2))
            {
                case 1: return new Numeric.NumericalOperation().    Substract(operand1, operand2);
                case 2: return new String.StringOperation().        Substract(operand1, operand2);
                case 3: return new Boolean.BooleanOperation().      Substract(operand1, operand2);
                default:
                    throw new Exception("\nError in operation \"Substract\" between:\n" +
               "Type " + operand1.GetType() + " : " + operand1 + " and\n" +
               "Type " + operand2.GetType() + " : " + operand2 + " and\n");
            }
        }
    }
}
