#pragma warning disable
/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2019 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later.
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using Dev2.Common.Interfaces.Core.Convertors.DateAndTime;
using System;
using System.Globalization;

namespace Dev2.Common.DateAndTime.TO
{
    public class DateTimeResultTO : IDateTimeResultTO
    {
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }
        public int DaysOfWeek { get; set; }
        public int DaysOfYear { get; set; }
        public int Weeks { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Milliseconds { get; set; }
        public bool Is24H { get; set; }
        public DateTimeAmPm AmPm { get; set; }
        public string Era { get; set; }
        public ITimeZoneTO TimeZone { get; set; }
        public DateTimeResultTO()
        {
            TimeZone = new TimeZoneTO(TimeZoneInfo.Local.StandardName, TimeZoneInfo.Local.StandardName, TimeZoneInfo.Local.DisplayName);
        }
        public DateTime ToDateTime()
        {
            NormalizeHours();

            if (Years == 0)
            {
                Years = DateTime.MinValue.Year;
            }

            if (Months == 0)
            {
                NormalizeMonths();
            }

            if (Days == 0)
            {
                NormalizeDays();
            }

            if (Hours == 0)
            {
                Hours = DateTime.MinValue.Hour;
            }

            if (Minutes == 0)
            {
                Minutes = DateTime.MinValue.Minute;
            }

            if (Seconds == 0)
            {
                Seconds = DateTime.MinValue.Second;
            }

            if (Milliseconds == 0)
            {
                Milliseconds = DateTime.MinValue.Millisecond;
            }

            return new DateTime(Years, Months, Days, Hours, Minutes, Seconds, Milliseconds);
        }
        public void NormalizeDays()
        {
            Days = DateTime.MinValue.Day;
            if (DaysOfWeek != 0)
            {
                var tmpDate = new DateTime(Years, Months, Days);
                Days = tmpDate.AddDays(DaysOfWeek - DateTimeParserHelper.GetDayOfWeekInt(tmpDate.DayOfWeek)).Day;
            }
        }
        public void NormalizeMonths()
        {
            if (DaysOfYear != 0)
            {
                var tmpDate = new DateTime(Years, 1, 1).AddDays(DaysOfYear - 1);
                Months = tmpDate.Month;

                if (Days == 0)
                {
                    Days = tmpDate.Day;
                }
            }
            else if (Weeks != 0)
            {
                var tmpDate = CultureInfo.CurrentCulture.Calendar.AddWeeks(new DateTime(Years, 1, 1), Weeks);
                Months = tmpDate.Month;

                if (Days == 0)
                {
                    Days = tmpDate.Day;
                }
            }
            else
            {
                Months = DateTime.MinValue.Month;
            }
        }
        public void NormalizeHours()
        {
            if (Is24H && Hours >= 12)
            {
                AmPm = DateTimeAmPm.pm;
            }
            else if (Hours > 12)
            {
                Is24H = true;
                AmPm = DateTimeAmPm.pm;
            }
            else if (AmPm == DateTimeAmPm.pm)
            {
                Is24H = true;
                if (Hours != 12)
                {
                    Hours += 12;
                }
            }
            else
            {
                if (AmPm == DateTimeAmPm.am)
                {
                    Is24H = true;
                    if (Hours >= 12)
                    {
                        Hours -= 12;
                    }
                }
            }
        }
    }
}