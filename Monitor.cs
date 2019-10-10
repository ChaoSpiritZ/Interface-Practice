using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InterfacePractice
{
    class Monitor
    {
        public delegate void Error(string componentName);
        public delegate void OK(string componentName);

        public event Error OnError;
        public event OK OnOK;

        private List<IMonitoredComponent> _monitoredList = new List<IMonitoredComponent>();

        public Monitor()
        {
        }
        public void AddMonitoredComponent(IMonitoredComponent comp)
        {
                _monitoredList.Add(comp);
        }

        public void Start()
        {
            Thread thread1 = new Thread(Run);
            thread1.Start();
        }

        private void Run()
        {
            while (true)
            {
                for (int i = 0; i < _monitoredList.Count; i++)
                {
                    if (_monitoredList[i].GetStatus() == EnumStatus.OK)
                    {
                        if(OnOK != null)
                        OnOK(_monitoredList[i].GetComponentName());
                    }
                    if (_monitoredList[i].GetStatus() == EnumStatus.ERROR)
                    {
                        if (OnError != null)
                            OnError(_monitoredList[i].GetComponentName());
                    }
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
