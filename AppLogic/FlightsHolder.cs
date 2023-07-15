using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class FlightsHolder
    {
        protected int m_StartTime;
        protected int m_EndTime;

        public int StartTime
        {
            get { return m_StartTime; }
            internal protected set { m_StartTime = value; }
        }

        public int EndTime
        {
            get { return m_EndTime; }
            internal protected set { m_EndTime = value; }
        }
    }
}
