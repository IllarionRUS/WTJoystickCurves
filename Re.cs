using System;
using System.Collections.Generic;

using System.Text;
using System.Text.RegularExpressions;

namespace WTJoystickCurves
{
    public static class Re
    {
        public static string GetSubString(string input, string re, int index)
        {
            var match = Regex.Match(input, re, RegexOptions.Singleline | RegexOptions.IgnoreCase);
            if (!match.Success)
                return null;

            if (match.Groups.Count <= index)
                return null;

            var result = match.Groups[index].Value;

            if (String.IsNullOrEmpty(result))
            {
                return null;
            }

            return result;

        }
    }
}
