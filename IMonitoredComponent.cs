using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    interface IMonitoredComponent
    {
        string GetComponentName();
        EnumStatus GetStatus();
    }

    enum EnumStatus
    {
        OK = 1,
        ERROR = 2
    }
}
