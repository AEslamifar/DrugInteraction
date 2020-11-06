using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Drug.Class
{
    class Public_Class
    {
        public static string ConvertToDay_Month()
        {
            string str = "";

            DateTime time1 = new DateTime();
            time1 = DateTime.Now;
            PersianCalendar objCalender = new PersianCalendar();


            System.Globalization.PersianCalendar x = new System.Globalization.PersianCalendar();
            DateTime dt = x.ToDateTime(Convert.ToInt16(objCalender.GetYear(time1).ToString()), Convert.ToInt16(objCalender.GetMonth(time1).ToString()), Convert.ToInt16(objCalender.GetDayOfMonth(time1).ToString()), 0, 0, 0, 0);
            int WeekOfYear = x.GetWeekOfYear(dt, CalendarWeekRule.FirstDay, 0);
            string DayOfWeek1 = x.GetDayOfWeek(dt).ToString();
            string MonthOfYear = x.GetMonth(dt).ToString();

            switch (MonthOfYear)
            {
                case "1": { MonthOfYear = "فروردین"; }; break;
                case "2": { MonthOfYear = "اردیبهشت"; }; break;
                case "3": { MonthOfYear = "خرداد"; }; break;
                case "4": { MonthOfYear = "تیر"; }; break;
                case "5": { MonthOfYear = "مرداد"; }; break;
                case "6": { MonthOfYear = "شهریور"; }; break;
                case "7": { MonthOfYear = "مهر"; }; break;
                case "8": { MonthOfYear = "آبان"; }; break;
                case "9": { MonthOfYear = "آذر"; }; break;
                case "10": { MonthOfYear = "دی"; }; break;
                case "11": { MonthOfYear = "بهمن"; }; break;
                case "12": { MonthOfYear = "اسفند"; }; break;
            }


            switch (DayOfWeek1)
            {
                case "Saturday": { DayOfWeek1 = "شنبه"; }; break;
                case "ُُSunday": { DayOfWeek1 = "یکشنبه"; }; break;
                case "Monday": { DayOfWeek1 = "دوشنبه"; }; break;
                case "Tuesday": { DayOfWeek1 = "سه شنبه"; }; break;
                case "Wednesday": { DayOfWeek1 = "چهارشنبه"; }; break;
                case "Thursday": { DayOfWeek1 = "پنجشنبه"; }; break;
                case "Friday": { DayOfWeek1 = "جمعه"; }; break;
            }

            if (DayOfWeek1 == "Sunday")
                DayOfWeek1 = "یکشنبه";



            return str = DayOfWeek1 + " " + objCalender.GetDayOfMonth(time1).ToString() + " " + MonthOfYear + " " + objCalender.GetYear(time1).ToString();



        }
    }
}
