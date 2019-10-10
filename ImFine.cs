using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class ImFine : IMonitoredComponent
    {
        public string Name { get; set; }

        public ImFine(string name)
        {
            Name = name;
        }

        public string GetComponentName()
        {
            return Name;
        }

        public EnumStatus GetStatus()
        {
            return EnumStatus.OK;
        }
    }
}
