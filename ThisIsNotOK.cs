using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class ThisIsNotOK : IMonitoredComponent
    {
        public string Name { get; set; }

        public ThisIsNotOK(string name)
        {
            Name = name;
        }

        public string GetComponentName()
        {
            return Name;
        }

        public EnumStatus GetStatus()
        {
            return EnumStatus.ERROR;
        }
    }
}
