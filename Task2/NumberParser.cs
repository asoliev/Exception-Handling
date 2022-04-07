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

            if (stringValue == "")
            {
                throw new FormatException(stringValue);
            }

            try
            {
                return Convert.ToInt32(stringValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}