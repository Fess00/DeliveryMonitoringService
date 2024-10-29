using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryMonitoringDataModel
{
    public class DeliveryDateTime
    {
        DateTime _dateTime;
        const string _format = "yyyy-MM-dd HH:mm:ss";
        public DateTime DT => _dateTime;

        public bool SetDate(string date)
        {
            return DateTime.TryParseExact(date, _format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _dateTime);
        }

        public override string ToString()
        {
            return _dateTime.ToString(_format);
        }
    }
}
