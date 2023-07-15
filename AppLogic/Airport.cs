using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class Airport : FlightsHolder
    {
        private List<Flight> m_incomingFlights;
        private List<Flight> m_outgoingFlights;

        public List<Flight> incomingFlights
        {
            get { return m_incomingFlights; }
            internal set { m_incomingFlights = value; }
        }

        public List<Flight> outgoingFlights
        {
            get { return m_outgoingFlights; }
            internal set { m_outgoingFlights = value; }
        }
    }
}
