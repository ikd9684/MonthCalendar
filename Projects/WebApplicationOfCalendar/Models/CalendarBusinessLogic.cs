using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

using WebApplicationOfCalendar.Controllers;

namespace WebApplicationOfCalendar.Models
{
    public class CalendarBusinessLogic
    {
        /// <summary>
        /// 表示するカレンダーのビューモデルを取得する
        /// </summary>
        /// <param name="aViewModel">ビューモデル</param>
        /// <returns>表示月のビューモデル</returns>
        public static CalendarViewModel getCalendar(CalendarViewModel aViewModel)
        {
            // カレンダーに表示した日数のカウント
            int dayCount = 0;

            // 現在日時までを取得
            DateTime sysdate = DateTime.Now;

            // 表示月の初日のオブジェクト取得
            DateTime firstDayOfMonth = new DateTime(sysdate.Year, sysdate.Month, 1);

            // 初日の曜日(数字に変換)
            int firstDaysPosition = (int)firstDayOfMonth.DayOfWeek;

            // 表示年（西暦）
            aViewModel.DisplayYear = sysdate.Year;

            // 表示月
            aViewModel.DisplayMonth = sysdate.Month;

            // 表示月の日数
            int dayInMonth = DateTime.DaysInMonth(aViewModel.DisplayYear, aViewModel.DisplayMonth);

            // １週目取得
            aViewModel.firstWeekList = new List<string>(getFirstWeekList(ref dayCount, firstDaysPosition));

            // ２週目取得
            aViewModel.secondWeekList = new List<string>(getWeekDay(ref dayCount, dayInMonth));

            // ３週目取得
            aViewModel.thirdWeekList = new List<string>(getWeekDay(ref dayCount, dayInMonth));

            // ４週目取得
            aViewModel.fourthWeekList = new List<string>(getWeekDay(ref dayCount, dayInMonth));

            // ５週目取得
            aViewModel.fifthWeekList = new List<string>(getWeekDay(ref dayCount, dayInMonth));

            // ６週目取得
            aViewModel.sixthWeekList = new List<string>(getWeekDay(ref dayCount, dayInMonth));

            return aViewModel;
        }

        /// <summary>
        /// 1週目を取得する
        /// </summary>
        /// <param name="aDayCount">取得日数のカウント</param>
        /// <param name="aFirstDayPosition">初日の表示位置</param>
        /// <returns></returns>
        public static List<string> getFirstWeekList(ref int aDayCount, int aFirstDayPosition)
        {
            List<string> aFirstWeekList = new List<string>();

            // 初日まで"．"でパディングする
            for (int j = 0; j < aFirstDayPosition ; j++)
            {
                aFirstWeekList.Add(".");
            }

            // 土曜日まで日数を格納する
            for (int i = 0; i < 7 - aFirstDayPosition ; i++) 
            {
                aDayCount++;
                aFirstWeekList.Add((i + 1).ToString());
            }
            return aFirstWeekList;
        }

        /// <summary>
        /// 2週目以降のカレンダーを取得する
        /// </summary>
        /// <param name="aDayCount">日数のカウント</param>
        /// <param name="aDayInMonth">表示月の日数</param>
        /// <returns>１週分の日にちを格納したリスト</returns>
        public static List<string> getWeekDay(ref int aDayCount, int aDayInMonth)
        {
            List<string> aWeeklyList = new List<string>();

            for (int i = 0; i < 7; i++) 
            {
                aDayCount++;
                if (aDayCount > aDayInMonth)
                {
                    // 最終日まで格納した場合"."でパディングする。
                    aWeeklyList.Add(".");
                }
                else 
                {
                    aWeeklyList.Add(aDayCount.ToString());
                }
            }
            return aWeeklyList;
        }
    }
}
