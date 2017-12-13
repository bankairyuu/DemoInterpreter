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
    class ProgramLine : INonTerminals
    {
        public object Execute(GOLD.Reduction node)
        {
            try
            {
                string type = Regex.Replace(node[0].Parent.ToString(), "[^0-9a-zA-Z]+", "");
                Enumerations.eEnumerations ntt = (Enumerations.eEnumerations)Enum.Parse(typeof(Enumerations.eEnumerations), type);

                switch (ntt)
                {
                    case Enumerations.eEnumerations.Expression:
                        var returnValue = Context.Context.Execute(ntt, (GOLD.Reduction)node[0].Data);
                        return returnValue;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                string EMPTY = "Empty ProgramLine";
                return EMPTY;
            }

            return null;
        }

        public object Operation(object operand1, string operatorString, object operand2)
        {
            throw new NotImplementedException();
        }
    }
}
