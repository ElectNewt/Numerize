namespace Numerize
{
    public static class Others
    {
        public static Numerize Hundred(this Numerize numerize)
        {
            return numerize.Append(Separator.Hundred);
        }
        public static Numerize Thousand(this Numerize numerize)
        {
            return numerize.Append(Separator.Thousand);
        }
        public static Numerize Milion(this Numerize numerize)
        {
            return numerize.Append(Separator.Million);
        }
        public static Numerize Billion(this Numerize numerize)
        {
            return numerize.Append(Separator.Billion);
        }

    }
}
