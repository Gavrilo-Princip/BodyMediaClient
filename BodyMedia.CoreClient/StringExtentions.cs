using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace BodyMedia.CoreClient
{
    public static class StringExtentions
    {
        public static DateTime ToDateTime(this string dt)
        {
            if(Regex.IsMatch(dt, "^[0-9]{8}$"))
                return DateTime.ParseExact(dt, "yyyyMMdd", CultureInfo.InvariantCulture);

            const string javaIsoMalform = "^(?<year>[0-9]{4})(?<month>[0-9]{2})(?<day>[0-9]{2})T(?<hour>[0-9]{2})(?<min>[0-9]{2})(?<sec>[0-9]{2})-(?<tzhour>[0-9]{2})(?<tzmin>[0-9]{2})$";
            if(Regex.IsMatch(dt, javaIsoMalform))
            {
                var match = Regex.Match(dt, javaIsoMalform);
                dt = string.Format("{0}-{1}-{2}T{3}:{4}:{5}-{6}:{7}",
                    match.Groups["year"].Value,
                    match.Groups["month"].Value,
                    match.Groups["day"].Value,
                    match.Groups["hour"].Value,
                    match.Groups["min"].Value,
                    match.Groups["sec"].Value,
                    match.Groups["tzhour"].Value,
                    match.Groups["tzmin"].Value);
            }

            return DateTime.Parse(dt);
        }
    }
}
