using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Flight
    {        
        private int _timeOfFlight;

        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }

        public int TimeOfFlight
        {
            get => _timeOfFlight;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Время полета не может быть отрицательным");
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

        public Flight()
        {
            
        }
    }
}
