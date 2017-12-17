using DemoInterpreter.GOLD_Logic.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOLD;
using System.Text.RegularExpressions;

namespace DemoInterpreter.GOLD_Logic.Model.Classes
{
    class Factor : INonTerminals
    {
        public object Execute(GOLD.Reduction node)
        {
            if (node.Count() == 3)
            {
                try
                {
                    string type = Regex.Replace(node[1].Parent.ToString(), "[^0-9a-zA-Z]+", "");
                    Enumerations.eEnumerations ntt = (Enumerations.eEnumerations)Enum.Parse(typeof(Enumerations.eEnumerations), type);

                    switch (ntt)
                    {
                        case Enumerations.eEnumerations.Expression:
                            var returnValue = Context.Context.Execute(ntt, (GOLD.Reduction)node[1].Data);
                            return returnValue;

                        default:
                            break;
                    }
                }
                catch (Exception)
                { }
            }
            else if (node.Count() == 2)
            {
                string _operator = null;
                object _operand = null;

                for (int i = 0; i < node.Count(); i++)
                {
                    switch (node[i].Type())
                    {
                        case GOLD.SymbolType.Nonterminal: // Nemterminálisok vizsgálata

                            string type = Regex.Replace(node[i].Parent.ToString(), "[^0-9a-zA-Z]+", "");
                            Enumerations.eEnumerations ntt = (Enumerations.eEnumerations)Enum.Parse(typeof(Enumerations.eEnumerations), type);

                            _operand = Context.Context.Execute(ntt, (GOLD.Reduction)node[i].Data);

                            break;

                        case GOLD.SymbolType.Error:
                            break;

                        default:
                            // Terminálisok vizsgálata - itt operátor jel
                            _operator = node[i].Data as string;
                            break;
                    }
                }

                if (_operator != null)
                    _operand = Operation(_operand, _operator, null);
                return _operand;
            }
            else
            {
                object returnValue = null;
                try
                {
                    if (node[0].Parent.ToString().Equals("NumberLiteral"))
                    {
                        returnValue = Int32.Parse(node[0].Data.ToString());
                        return Int32.Parse(node[0].Data.ToString());
                    }
                    else if (node[0].Parent.ToString().Equals("StringLiteral"))
                    {
                        returnValue = node[0].Data.ToString();
                        return node[0].Data.ToString();
                    }
                    else if (node[0].Parent.ToString().Equals("BooleanLiteral"))
                    {
                        if (node[0].Data.ToString().Equals("true") || node[0].Data.ToString().Equals("yes"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        throw new Exception("Literal define error - Luna_interpreter.Model.Structure.Classes.Factor.Execute");
                    }
                }
                catch (InvalidCastException ice)
                {
                    Console.WriteLine(ice.Message);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            return null;
        }

        public object Operation(object operand1, string operatorString, object operand2)
        {
            return ArithmeticalClasses.Deflector.OperationResolver(operand1, operatorString, operand2);
        }
    }
}
