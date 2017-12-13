using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterpreter.GOLD_Logic
{
    class Reduction
    {
        public object ReductionValue(GOLD.Reduction Root) => Model.Context.Context.Execute(Enumerations.eEnumerations.ProgramLine, (GOLD.Reduction)Root[0].Data);
    }
}
