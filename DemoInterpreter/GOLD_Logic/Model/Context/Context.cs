using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterpreter.GOLD_Logic.Model.Context
{
    public static class Context
    {
        private static Dictionary<Enumerations.eEnumerations, Interfaces.INonTerminals> _strategies = new Dictionary<Enumerations.eEnumerations, Interfaces.INonTerminals>();
        static Context()
        {
            _strategies.Add(Enumerations.eEnumerations.ProgramLine,         new Classes.ProgramLine());
            _strategies.Add(Enumerations.eEnumerations.Expression,          new Classes.Expression());
            _strategies.Add(Enumerations.eEnumerations.SimpleExpression,    new Classes.SimpleExpression());
            _strategies.Add(Enumerations.eEnumerations.Term,                new Classes.Term());
            _strategies.Add(Enumerations.eEnumerations.Factor,              new Classes.Factor());
        }
        public static object Execute(Enumerations.eEnumerations type, GOLD.Reduction node) => _strategies[type].Execute(node);
    }
}
