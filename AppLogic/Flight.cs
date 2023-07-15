using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppLogic
{
    public class Flight
    {
        [JsonProperty(PropertyName = "icao24")]
        private string m_AircraftID;

        [JsonProperty(PropertyName = "firstseen")]
        private int m_DepartureTime;

        [JsonProperty(PropertyName = "estDepartureAirport")]
        private string m_DepartureAirport;

        [JsonProperty(PropertyName = "lastseen")]
        private int m_ArrivalTime;

        [JsonProperty(PropertyName = "estArrivalAirport")]
        private string m_ArrivalAirport;

        [JsonProperty(PropertyName = "callsign")]
        private string m_FlightID;

        public string AircraftID
        {
            get { return m_AircraftID; }
        }

        public int DepartureTime
        {
            get { return m_DepartureTime; }
        }

        public string DepartureAirport
        {
            get { return m_DepartureAirport; }
        }

        public int ArrivalTime
        {
            get { return m_ArrivalTime; }
        }

        public string ArrivalAirport
        {
            get { return m_ArrivalAirport; }
        }

        public string FlightID
        {
            get { return m_FlightID; }
        }
    }
}
