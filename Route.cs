using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRPZ3
{
    public class Route
    {
        public string Name { get; }
        public string StartDate { get; }
        public string EndDate { get; }
        public List<string> Destinations { get; }

        public Route(string name, string startDate, string endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Destinations = new List<string>();
        }
        public void AddDestination(string destination)
        {   
            if (!Destinations.Contains(destination))
            {
                Destinations.Add(destination);
            }
        }
        public void RemoveDestination(string destination)
        {
            if (Destinations.Contains(destination))
            {
                Destinations.Remove(destination);
            }
        }
    }
}
