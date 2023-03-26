using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TransportChecker.domain
{
    class City
    {
        public string name { get; set; }

        private Dictionary<string, int> distance { get; set; }

        public City(string name, Dictionary<string, int> distances) {
            this.name = name;
            this.distance = distances;
        }

        public int findDistanceBetweenCities(string destination)
        {
            return distance[destination];
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
