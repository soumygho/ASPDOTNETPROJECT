using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace offsetLibrary
{
    public class CreateDateClass
    {
        public string createDate(string date)
        {
            string _date = null;
            DateTime _datetime = DateTime.Parse(date, CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat);
            _date = _datetime.ToShortDateString();
            _date = '#' + _date + '#';
            string datequery = "CDate(" + _date + ")";
            return datequery;
        }
    }
}
