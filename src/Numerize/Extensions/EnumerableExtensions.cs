namespace Numerize.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TSource> Exclude<TSource, TKey>(this IEnumerable<TSource> source,
        IEnumerable<TSource> exclude, Func<TSource, TKey> keySelector)
        {
            var excludedSet = new HashSet<TKey>(exclude.Select(keySelector));
            return source.Where(item => !excludedSet.Contains(keySelector(item)));
        }

        public static IEnumerable<TSource> Include<TSource, TKey>(this IEnumerable<TSource> source,
        IEnumerable<TSource> include, Func<TSource, TKey> keySelector)
        {
            var includedSet = new HashSet<TKey>(include.Select(keySelector));
            return source.Where(item => includedSet.Contains(keySelector(item)));
        }
    }
}
