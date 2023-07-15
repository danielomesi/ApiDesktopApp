using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogic;

namespace AppGUI
{
    internal class Utils
    {

        internal static string FlightAsString(Flight i_Flight, Dictionary<string,string> i_Airports)
        {
            string departureTime = unixTimeToDate(i_Flight.DepartureTime);
            string arrivalTime = unixTimeToDate(i_Flight.ArrivalTime);
            string departureAirport = "Unknown";
            string arrivalAirport = "Unknown";

            try
            {
                if (i_Flight.ArrivalAirport != null)
                {
                    arrivalAirport = i_Airports[i_Flight.ArrivalAirport];
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (i_Flight.DepartureAirport != null)
                {
                    departureAirport = i_Airports[i_Flight.DepartureAirport];
                }
            }
            catch (Exception ex)
            {

            }

            string res = string.Format("Flight #{0} departed from {1} at {2} and landed in {3} at {4}",
                i_Flight.FlightID, departureAirport, departureTime, arrivalAirport, arrivalTime);

            return res;
        }

        internal static string GetIcao(Dictionary<string,string> i_Airports, string airportName)
        {
            string res = null;

            foreach(KeyValuePair<string,string> pair in i_Airports)
            {
                if (pair.Value==airportName)
                {
                    res = pair.Key;
                }
            }

            return res;
        }

        private static string unixTimeToDate(int i_UnixTime)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(i_UnixTime);
            DateTime dateTime = dateTimeOffset.DateTime;

            string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

            return formattedDateTime;
        }

        public static void CheckFormData(ComboBox i_ComboBoxWhichFlights,ComboBox i_ComboBoxFlightHolder)
        {
            if (i_ComboBoxFlightHolder.SelectedItem==null || (i_ComboBoxFlightHolder.SelectedItem.ToString() == "Airport" 
                && i_ComboBoxWhichFlights.SelectedItem == null) )
                throw new ArgumentNullException();
        }
    }
}
