using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAULT_Configurator
{
    enum FaultType
    {
        MINOR = 0,
        MAJOR = 1,
        INFO = 2
    }

    enum FaultState
    {
        INACTIVE = 0,
        ACTIVE = 1
    }

    class Fault
    {
        public string Name { get; set; }
        public FaultType Type { get; set; }
        public FaultType InitState { get; set; }

        public string TextConditionApp { get; set; }
        public string TextActionApp { get; set; }
        public string TextConditionDisp { get; set; }
        public string TextActionDisp { get; set; }

        public Fault()
        {

        }
    }
}
