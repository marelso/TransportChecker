using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportChecker.domain
{
    enum VehicleType
    {
        Low,
        Medium,
        High
    }

    class Vehicle
    {
        public VehicleType type { get; private set; }

        public double maximumWeight { get; private set; }

        public double costPerKm { get; private set; }

        public Vehicle(VehicleType type)
        {
            switch(type)
            {
                case VehicleType.Low:
                    this.type = VehicleType.Low;
                    this.maximumWeight = 1000; 
                    this.costPerKm = 4.87;
                    break;
                case VehicleType.Medium:
                    this.type = VehicleType.Medium;
                    this.maximumWeight = 4000;
                    this.costPerKm = 11.92;
                    break;
                case VehicleType.High:
                    this.type = VehicleType.High;
                    this.maximumWeight = 10000;
                    this.costPerKm = 27.44;
                    break;

                default:
                    this.type = VehicleType.Low;
                    this.maximumWeight = 1.0;
                    this.costPerKm = 4.87;
                    break;
            }
        }
    }
}
