using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    class Aircraft : FlightsHolder
    {
        private List<Flight> m_Flights;

        public List<Flight> Flights
        {
            get { return m_Flights; }
            internal set { m_Flights = value; }
        }
    }
}
