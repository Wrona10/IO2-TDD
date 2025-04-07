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

            if(duration <= 0)
            {
                throw new ArgumentException("Duration must be greater than zero.");
            }

            double powerConsumption = 0;

            switch (machineType)
            {
                case "MillingMachine":
                    powerConsumption = 5 * duration;
                    break;
                default:
                    throw new ArgumentException("Invalid machine type");
            }

            throw new NotImplementedException();
        }
    }
}
