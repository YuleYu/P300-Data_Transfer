using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_YH
{
    public class TimeStamp
    {
       
        int _order;
        string _name;
        int _frequency;
        //string _time;
        //DateTime _time;
        long _time;

        public TimeStamp(TimeStamp TS)
        {
            _order = TS.order;
            _name = TS.name;
            _frequency = TS.frequency;
            _time = TS.time;
        }

        public TimeStamp(int order, string name, int fre, long time)
        {
            _order = order;
            _name = name;
            _frequency = fre;
            _time = time;
        }

        public int order { get { return _order; } }
        public string name { get { return _name; } }
        public int frequency { get { return _frequency; } }
        public long time { get { return _time; } }


        
    }
}
