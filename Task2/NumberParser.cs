using System;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException(stringValue);
            }
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                throw new FormatException(stringValue);
            }
            string s = stringValue.Trim();

            bool isNegative = false;
            long response = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (i == 0)
                {
                    isNegative = c == '-';
                    if (c == '+' || isNegative) continue;
                }

                if (!"0123456789".Contains(c)) throw new FormatException(s);

                response *= 10;
                if (isNegative) response -= c - '0';
                else response += c - '0';

                if (response < int.MinValue || response > int.MaxValue)
                {
                    throw new OverflowException(s);
                }
            }
            return (int)response;
        }
    }
}