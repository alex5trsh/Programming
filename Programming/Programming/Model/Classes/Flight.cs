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
        private int TimeOfFlightInMinutes
        {
            //get { }
            set
            {
                if (value < 0)
                { }
            }
        }
    }
}
