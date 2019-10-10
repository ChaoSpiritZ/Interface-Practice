using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor m = new Monitor();
            m.OnError += ShowError;
            m.OnOK += ShowOK;
            m.AddMonitoredComponent(new ImFine("Awesome System #1"));
            m.AddMonitoredComponent(new ThisIsNotOK("Horrible System #1"));
            m.AddMonitoredComponent(new ThisIsNotOK("Horrible System #2"));
            m.AddMonitoredComponent(new ImFine("Awesome System #2"));
            m.Start();

            while (true)
            {
                Console.ReadLine();
            }
        }

        public static void ShowError(string componentName)
        {
            Console.WriteLine("The component monitored reported on an error on " + componentName);
        }

        public static void ShowOK(string componentName)
        {
            Console.WriteLine("The component monitored reported on an OK status on " + componentName);
        }
    }
}
