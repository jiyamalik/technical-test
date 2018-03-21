namespace TechnicalTestCore
{
    using System;
    using System.Linq;

    internal class Summations
    {
        public static int SumOfNumbersFrom1Till(int maxInt)
        {
            var sum = 0;
            for (var i = 1; i <= maxInt; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static string SumOfIntegersFrom70KTill(int maxInt)
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
