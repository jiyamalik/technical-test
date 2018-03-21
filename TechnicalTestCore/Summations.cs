namespace TechnicalTestCore
{
    using System;
    using System.Linq;

    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            var sum = 0;
            for (var i = 1; i <= maxInt; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            long sum = 0;
            for (var i = 1; i <= maxInt; i++)
            {
                sum += i;
            }

            return sum.ToString();
        }
    }
}
