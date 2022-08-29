using Numerize.Extensions;

namespace Numerize
{
    internal class NumericRecord
    {
        public decimal Value;
        public Separator Separator;
        internal Guid Identifier;
        internal string? StringValue;

        public static implicit operator NumericRecord(long value) => new NumericRecord(value);
        public static implicit operator NumericRecord(decimal value) => new NumericRecord(value);
        public static implicit operator NumericRecord(int value) => new NumericRecord(value);
        public static implicit operator NumericRecord(Separator separator) => new NumericRecord(separator);

        internal NumericRecord(decimal number)
        {
            Value = number;
            Separator = Separator.None;
            Identifier = Guid.NewGuid();
            StringValue = number.TryConvertNumberToString();
        }

        internal NumericRecord(Separator separator)
        {
            Separator = separator;
            StringValue = separator.ToString();
            Value = separator.CalculateSeparatorAmount();
        }
    }
}
