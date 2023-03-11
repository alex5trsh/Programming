using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Flight
    {
        private string DeparturePoint { get; set; }

        private string DestinationPoint { get; set; }

        private int _timeOfFlight;

        private int TimeOfFlight
        {
            get => _timeOfFlight;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _timeOfFlight=value;
            }
        }
        public Flight(string departurePoint, string destinationPoint, int timeOfFlight)
        {
            DeparturePoint= departurePoint;
            DestinationPoint= destinationPoint;
            TimeOfFlight= timeOfFlight;
        }
    }
}
