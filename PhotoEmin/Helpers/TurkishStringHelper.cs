using System.Globalization;

namespace PhotoEmin.Helpers
{
    public static class TurkishStringHelper
    {
        private static readonly CultureInfo TurkishCulture = new("tr-TR");

        public static string ToUpperTurkish(string input)
            => input.ToUpper(TurkishCulture);

        public static string[] SplitAndReturn(string input)
        {
            int index = input.IndexOf(':');
            if (index == -1 || index == 0)
                return ["", ""];

            return [input[..(index + 1)], input[(index + 1)..]];
        }
    }
}
