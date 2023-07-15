using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class RequestData
    {
        private eTypeOfFlightsData m_TypeOfFlightsData;
        private eFlightsTimePerspective m_FlightsTimePerspective;
        private string m_SearchParam;
        private int m_BeginTime;
        private int m_EndTime;

        public RequestData(eTypeOfFlightsData i_TypeOfFlightsData, eFlightsTimePerspective i_FlightsTimePerspective, string i_SearchParam, int i_BeginTime, int i_EndTime)
        {
            m_TypeOfFlightsData = i_TypeOfFlightsData;
            m_FlightsTimePerspective = i_FlightsTimePerspective;
            m_SearchParam = i_SearchParam;
            m_BeginTime = i_BeginTime;
            m_EndTime = i_EndTime;
        }

        public eTypeOfFlightsData TypeOfFlightsData
        {
            get { return m_TypeOfFlightsData; }
            set { m_TypeOfFlightsData = value; }
        }

        public eFlightsTimePerspective FlightsTimePerspective
        {
            get { return m_FlightsTimePerspective; }
            set { m_FlightsTimePerspective = value; }
        }

        public string SearchParam
        {
            get { return m_SearchParam; }
            set { m_SearchParam = value; }
        }

        public int BeginTime
        {
            get { return m_BeginTime; }
            set { m_BeginTime = value; }
        }

        public int EndTime
        {
            get { return m_EndTime; }
            set { m_EndTime = value; }
        }

    }
}
