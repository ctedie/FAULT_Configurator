using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAULT_Configurator
{
    enum FaultType
    {
        MINEUR = 0,
        MAJEUR = 1,
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
        public FaultState InitState { get; set; }

        public string TextDescription { get; set; }
        public string TextConditionApp { get; set; }
        public string TextActionApp { get; set; }
        public string TextConditionDisp { get; set; }
        public string TextActionDisp { get; set; }
        public string TextPresence { get; set; }

        public Fault()
        {
            this.Type = FaultType.INFO;
            this.InitState = FaultState.INACTIVE;

        }
    }
}
