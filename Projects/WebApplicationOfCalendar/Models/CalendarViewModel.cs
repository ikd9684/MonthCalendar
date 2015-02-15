using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationOfCalendar.Models
{
    /// <summary>
    /// カレンダーに表示する各週の定義
    /// </summary>
    public class CalendarViewModel 
    {
        public int DisplayYear { get; set; }
        public int DisplayMonth { get; set; }
        public List<string> firstWeekList { get; set; }
        public List<string> secondWeekList { get; set; }
        public List<string> thirdWeekList { get; set; }
        public List<string> fourthWeekList { get; set; }
        public List<string> fifthWeekList { get; set; }
        public List<string> sixthWeekList { get; set; }
    }
}
