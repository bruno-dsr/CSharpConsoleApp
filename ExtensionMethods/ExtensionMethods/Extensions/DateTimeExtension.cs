using System;
using System.Globalization;

namespace ExtensionMethods.Extensions
{
    static class DateTimeExtension
    {
        static public string ElapsedTime(this DateTime thisDT)
        {
            TimeSpan span = DateTime.Now.Subtract(thisDT);
            string response = string.Empty;

            if (span.TotalHours < 24.0)
            {
                response = span.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";
            }

            else
            {
                response = span.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " dias";
            }

            return response;
        }
    }
}
