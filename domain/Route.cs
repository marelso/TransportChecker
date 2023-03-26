using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportChecker.domain
{
    class Route
    {
        public City origin { get; set; }

        public City destination { get; set; }

        public List<Vehicle> vehicles { get; set; }

        public double totalWeight { get; private set; }

        public Route(City origin, City destination, List<Vehicle>? vehicles) {
            this.origin = origin;
            this.destination = destination;

            if(vehicles != null)
            {
                this.vehicles = vehicles;
            }
        }

        private int findDistanceBetweenCities()
        {
            return this.origin.findDistanceBetweenCities(this.destination.name);
        }
    }
}
