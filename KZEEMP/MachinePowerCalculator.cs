using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KZEEMP
{
    public class MachinePowerCalculator
    {
        public double GetPowerConsumption(string machineType, int duration, bool isEnergySaving)
        {
            if(machineType == "" || machineType is null)
            {
                throw new ArgumentException("Machine type cannot be empty.");
            }

            throw new NotImplementedException();
        }
    }
}
