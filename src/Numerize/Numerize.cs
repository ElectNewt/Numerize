using Numerize.Extensions;
using System.Collections.Immutable;

namespace Numerize
{
    public partial class Numerize
    {
        private List<NumericRecord> AllValues;
        private List<NumericRecord> currentSection;
        private List<NumericRecord> currentSubsection;
        private ImmutableArray<NumericRecord> processedValues;
        private Separator PreviousSeparator;

        public static implicit operator long(Numerize value) => Convert.ToInt64(value.GetValue());
        public static implicit operator decimal(Numerize value) => value.GetValue();
        public static implicit operator int(Numerize value) => Convert.ToInt32(value.GetValue());
        public static implicit operator string(Numerize value) => value.InWords();


        public Numerize()
        {
            AllValues = new List<NumericRecord>();
            currentSection = new List<NumericRecord>();
            currentSubsection = new List<NumericRecord>();
            processedValues = new ImmutableArray<NumericRecord>();
            PreviousSeparator = Separator.Unlimited;
        }

        public decimal GetValue()
        {
            return currentSection.Sum(a => a.Value) + currentSubsection.Sum(a => a.Value);
        }

        private string InWords()
        => string.Join(' ', AllValues.Where(a => !string.IsNullOrWhiteSpace(a.StringValue)).Select(a=>a.StringValue));

        internal Numerize Append(NumericRecord record)
        {

            AllValues.Add(record);

            if (record.Separator == Separator.None)
            {
                AddToCurrentSubSection(record);
            }
            else
            {
                CalculateCurrentSection(record);
            }

            return this;
        }



        private void AddToCurrentSubSection(NumericRecord record)
        {
            currentSubsection.Add(record);
        }


        private void CalculateSubsection(NumericRecord record)
        {
            List<NumericRecord> newSubsection = new();

            foreach (NumericRecord subsection in currentSubsection)
            {
                newSubsection.Add(subsection.Value * record.Value);
            }

            currentSubsection = newSubsection;
            processedValues = newSubsection.ToImmutableArray();
        }

        private void CalculateCurrentSection(NumericRecord record)
        {

            if (PreviousSeparator == Separator.Unlimited || PreviousSeparator < record.Separator)
            {
                CalculateSubsection(record);
                PreviousSeparator = record.Separator;
            }
            else
            {
                PreviousSeparator = Separator.Unlimited;
                currentSection.AddRange(currentSubsection.Include(processedValues, i => i.Identifier));
                currentSubsection = currentSubsection.Exclude(processedValues, i => i.Identifier).ToList();
                CalculateSubsection(record);

            }
        }

        public override string ToString()
        {
            return InWords();
        }


    }
}
