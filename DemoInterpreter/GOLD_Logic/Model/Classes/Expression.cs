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
    class Expression : INonTerminals
    {
        public object Execute(GOLD.Reduction node)
        {
            if (node.Count() == 3)
            {
                string _operator = null;
                object _operand1 = null, _operand2 = null;

                for (int i=0; i < node.Count(); i++)
                {
                    switch (node[i].Type())
                    {
                        case SymbolType.Nonterminal:
                            string type = Regex.Replace(node[i].Parent.ToString(), "[^0-9a-zA-Z]+", "");
                            Enumerations.eEnumerations ntt = (Enumerations.eEnumerations)Enum.Parse(typeof(Enumerations.eEnumerations), type);

                            if (_operand1 == null)
                            {
                                _operand1 = Context.Context.Execute(ntt, (GOLD.Reduction)node[i].Data);
                            }
                            else
                            {
                                _operand2 = Context.Context.Execute(ntt, (GOLD.Reduction)node[i].Data);
                            }

                            break;

                        case SymbolType.Error:
                            break;

                        default:
                            _operator = node[i].Data as string;
                            break;
                    }
                }

                if (_operator != null)
                    _operand1 = Operation(_operand1, _operator, _operand2);
                return _operand1;
            }
            else
            {
                string type = Regex.Replace(node[0].Parent.ToString(), "[^0-9a-zA-Z]+", "");
                Enumerations.eEnumerations ntt = (Enumerations.eEnumerations)Enum.Parse(typeof(Enumerations.eEnumerations), type);

                return Context.Context.Execute(ntt, (GOLD.Reduction)node[0].Data);
            }
        }

        public object Operation(object operand1, string operatorString, object operand2)
        {
            return ArithmeticalClasses.Deflector.OperationResolver(operand1, operatorString, operand2);
        }
    }
}
