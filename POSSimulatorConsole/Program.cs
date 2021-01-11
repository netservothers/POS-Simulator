using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSSimulator;

namespace POSSimulatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            POSSimulator.POSSimulator simulatorObj = new POSSimulator.POSSimulator();
            string Data = simulatorObj.ProcessReadRequest("02003536303030303030303030313032303030301C343000123030303030303031313030301C0315");
            Console.ReadLine();
        }
    }
}
