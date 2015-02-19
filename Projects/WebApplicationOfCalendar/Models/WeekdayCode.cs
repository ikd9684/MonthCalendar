using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationOfCalendar.Models
{
    /// <summary>
    /// 曜日の定義
    /// </summary>
    public class WeekdayCode
    {
        public const string sunday = "日";
        public const string monday = "月";
        public const string tuesday = "火";
        public const string wednesday = "水";
        public const string thursday = "木";
        public const string friday = "金";
        public const string saturday = "土";

        public static readonly string[] weekdays
            = {
                  sunday,
                  monday,
                  tuesday,
                  wednesday,
                  thursday,
                  friday,
                  saturday,
              };
    }
}
