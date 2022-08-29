namespace Numerize.Extensions
{
    internal static class NumericRecordExtensions
    {


        private static String[] _units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
        private static String[] _tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        internal static long CalculateSeparatorAmount(this Separator separator)
            => separator switch
            {
                Separator.None => 0,
                Separator.Decimal => 1,
                Separator.Hundred => 100,
                Separator.Thousand => 1_000,
                Separator.HundredThousand => 100_000,
                Separator.Million => 1_000_000,
                Separator.Billion => 1_000_000_000,
                Separator.Trillion => 1_000_000_000_000,
                _ => throw new NotImplementedException(),
            };


        internal static string? TryConvertNumberToString(this decimal number)
        {
            if(number <=19 || (number <= 90 && number%10 == 0))
            {
                return number <= 19 ? _units[(int)number] : _tens[(int)number / 10];
            }
            return null;
        }
           

    }
}
