using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoPackage
{
    public class ToDoBase
    {
        private const int URGENT_THRESHOLD_MINUTES = 60;
        private const int LATE_THRESHOLD_MINUTES = 0;

        public enum WarningLevel
        {
            Urgent,
            Safe,
            Late
        }

        public static string GetWarningLevel(DateTime dT, TimeZoneInfo timeZone)
        {
            DateTime current = DateTime.UtcNow;
            if (timeZone != null)
            {
                current = TimeZoneInfo.ConvertTimeFromUtc(current, timeZone);
            }

            TimeSpan timeUntilDue = dT - current;
            WarningLevel warningLevel;
            if (timeUntilDue.TotalMinutes < URGENT_THRESHOLD_MINUTES && timeUntilDue.TotalMinutes > LATE_THRESHOLD_MINUTES)
            {
                warningLevel = WarningLevel.Urgent;
            }
            else if (timeUntilDue.TotalMinutes > URGENT_THRESHOLD_MINUTES)
            {
                warningLevel = WarningLevel.Safe;
            }
            else
            {
                warningLevel = WarningLevel.Late;
            }

            switch (warningLevel)
            {
                case WarningLevel.Urgent:
                    return "Urgent";
                case WarningLevel.Safe:
                    return "Safe";
                case WarningLevel.Late:
                    return "Late";
                default:
                    return "Unknown";
            }
        }

    }

}

