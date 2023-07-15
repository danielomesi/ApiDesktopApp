using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogic;

namespace AppGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxFlightHolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if(comboBox.SelectedItem!=null)
            {
                labelParam.Text = comboBox.SelectedItem.ToString();
                labelParam.Visible = true;
                if (labelParam.Text == "Airport")
                {
                    textBoxSearchParam.Visible = false;
                    labelWhichFlights.Visible = true;
                    comboBoxWhichFlights.Visible = true;
                    if (m_Airports == null)
                    {
                        m_Airports = ServerAPI.GetAirportsDictionary();
                    }
                    updateComboBoxItems();
                    comboBoxAirport.Visible = true;
                }
                else
                {
                    comboBoxAirport.Visible = false;
                    textBoxSearchParam.Visible = true;
                    labelWhichFlights.Visible = false;
                    comboBoxWhichFlights.Visible = false;
                }
            }
            
        }

        private void updateComboBoxItems()
        {
            if (comboBoxAirport.Items.Count==0)
            {
                foreach (KeyValuePair<string, string> pair in m_Airports)
                {
                    comboBoxAirport.Items.Add(pair.Value);
                }
            }
            
        }

        private async void buttonFetchData_Click(object sender, EventArgs e)
        {
            List<Flight> flights;
            if (m_Airports==null)
            {
                m_Airports=ServerAPI.GetAirportsDictionary();
            }
            try
            {
                Utils.CheckFormData(comboBoxWhichFlights,comboBoxFlightHolder);
                RequestData requestData = getRequestDataFromForm();
                string requestUrl = ServerAPI.MakeUrl(requestData);
                flights = await ServerAPI.GetFlights(requestUrl);
                showFlightsDataInTextBox(flights);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void showFlightsDataInTextBox(List<Flight> Flights)
        {
            textBoxOutput.Text = "";
            foreach(Flight flight in Flights)
            {
                textBoxOutput.Text += Utils.FlightAsString(flight,m_Airports);
                textBoxOutput.Text += Environment.NewLine;
            }
        }

        private RequestData getRequestDataFromForm()
        {
            RequestData requestData;
            eTypeOfFlightsData typeOfFlightsData;
            eFlightsTimePerspective flightsTimePerspective;
            string searchParam;
            DateTimeOffset startTime = new DateTimeOffset(dateTimePickerStart.Value);
            int unixStartTime = (int)startTime.ToUnixTimeSeconds();
            DateTimeOffset endTime = new DateTimeOffset(dateTimePickerEnd.Value);
            int unixEndTime = (int)endTime.ToUnixTimeSeconds();


            if (comboBoxFlightHolder.SelectedItem.ToString() == "Airport")
            {
                typeOfFlightsData = eTypeOfFlightsData.Airport;
                searchParam = Utils.GetIcao(m_Airports, comboBoxAirport.Text);
            }
            else
            {
                typeOfFlightsData = eTypeOfFlightsData.Aircraft;
                searchParam = textBoxSearchParam.Text;
            }

            if (comboBoxWhichFlights.SelectedItem.ToString() == "Arrivals")
            {
                flightsTimePerspective = eFlightsTimePerspective.Arrival;
            }
            else if (comboBoxWhichFlights.SelectedItem.ToString() == "Departures")
            {
                flightsTimePerspective = eFlightsTimePerspective.Departure;
            }
            else
            {
                flightsTimePerspective = eFlightsTimePerspective.All;
            }

            requestData = new RequestData(typeOfFlightsData, flightsTimePerspective, searchParam,
                unixStartTime, unixEndTime);

            return requestData;
        }
    }
}
