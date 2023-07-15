using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Globalization;
using System.Text.Json;
using System.IO;

namespace AppLogic
{
    public static class ServerAPI
    {
        public static async Task<List<Flight>> GetFlights(string url)
        {
            List<Flight> flights;
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(url);
            flights = JsonConvert.DeserializeObject<List<Flight>>(response);

            return flights;
        }

        public static string MakeUrl(RequestData i_RequestData)
        {
            string searchType, specificSearchType;

            if (i_RequestData.TypeOfFlightsData==eTypeOfFlightsData.Aircraft)
            {
                searchType = "aircraft";
                specificSearchType = "icao24";
            }
            else
            {
                specificSearchType = "airport";
                if (i_RequestData.FlightsTimePerspective ==eFlightsTimePerspective.Arrival)
                {
                    searchType = "arrival";
                }
                else
                {
                    searchType = "departure";
                }
            }

            string url = string.Format("https://opensky-network.org/api/flights/{0}?{1}={2}&begin={3}&end={4}", searchType, specificSearchType
                , i_RequestData.SearchParam, i_RequestData.BeginTime, i_RequestData.EndTime);

            return url;
        }
        
        public static Dictionary<string,string> GetAirportsDictionary()
        {
            Dictionary<string, string> airportsMap = new Dictionary<string, string>();  
            string jsonContent = Properties.Resources.Airports;

            JsonDocument jsonDocument = JsonDocument.Parse(jsonContent);
            foreach (JsonElement element in jsonDocument.RootElement.EnumerateArray())
            {
                string icao = element.GetProperty("ICAO").GetString();
                string name = element.GetProperty("name").GetString();
                airportsMap[icao] = name;
            }

            return airportsMap;
        }
    }
}
