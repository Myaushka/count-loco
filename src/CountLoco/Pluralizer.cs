namespace CountLoco
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Threading;

    public class Pluralizer
    {
        private static readonly Dictionary<string, List<KeyValuePair<string, string>>> cachedRules =
            new Dictionary<string, List<KeyValuePair<string, string>>>();

        private static CultureInfo currentUICulture;

        public static string GetFormattedStringForNumber(string format, string number)
        {
            if (format == null)
            {
                throw new ArgumentNullException("format");
            }

            if (number == null)
            {
                throw new ArgumentNullException("number");
            }

            if (number == string.Empty || format == string.Empty)
            {
                return number;
            }

            var rules = GetRulesForFormat(format);

            foreach (var rule in rules)
            {
                if (Regex.IsMatch(number, rule.Key))
                {
                    return string.Format(rule.Value, number);
                }
            }

            return "UNDEFINED";
        }

        private static IEnumerable<KeyValuePair<string, string>> GetRulesForFormat(string format)
        {
            if (!Thread.CurrentThread.CurrentUICulture.Equals(currentUICulture))
            {
                currentUICulture = Thread.CurrentThread.CurrentUICulture;
                cachedRules.Clear();
            }

            if (cachedRules.ContainsKey(format))
            {
                // NOTE: this will not work properly if the language is changed at runtime.
                return cachedRules[format];
            }

            var groups = format.Split(new[]
            {
                '|'
            }, StringSplitOptions.RemoveEmptyEntries);

            var orderedRules = new List<KeyValuePair<string, string>>();

            foreach (var group in groups)
            {
                var tuple = group.Split(new[]
                {
                    '='
                }, StringSplitOptions.RemoveEmptyEntries);

                if (tuple.Length != 2)
                {
                    throw new ArgumentException(@"Format is not as expected.", "format");
                }

                var rules = tuple[0].Split(new[]
                {
                    ','
                }, StringSplitOptions.RemoveEmptyEntries);
                var value = tuple[1];

                foreach (var rule in rules)
                {
                    orderedRules.Add(new KeyValuePair<string, string>(rule, value));
                }
            }

            cachedRules.Add(format, orderedRules);

            return orderedRules;
        }
    }
}