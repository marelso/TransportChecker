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

        public Vehicle(VehicleType Type)
        {
            switch(type)
            {
                case VehicleType.Low:
                    this.type = VehicleType.Low;
                    this.maximumWeight = 1.0; 
                    this.costPerKm = 1.0;
                    break;
                case VehicleType.Medium:
                    this.type = VehicleType.Medium;
                    this.maximumWeight = 1.0;
                    this.costPerKm = 1.0;
                    break;
                case VehicleType.High:
                    this.type = VehicleType.High;
                    this.maximumWeight = 1.0;
                    this.costPerKm = 1.0;
                    break;

                default:
                    this.type = VehicleType.Low;
                    this.maximumWeight = 1.0;
                    this.costPerKm = 1.0;
                    break;
            }
        }
    }
}
