namespace Numerize.Test
{
    public class NumerizeStringTest
    {

        [Fact]
        public void TestSingleValue()
        {

            Numerize numerize = new Numerize();

            string result = numerize.Six();

            Assert.Equal("six", result.ToLower());
        }


        [Fact]
        public void TestVeryBigStringValue()
        {
            Numerize numerize = new Numerize();
            string result = numerize.Fourty().Three().Billion()
                .Two().Hundred().Nine().Milion()
                .Four().Hundred().Twelve().Thousand()
                .Sixteen();
            Assert.Equal("forty three billion two hundred nine million four hundred twelve thousand sixteen", result.ToLower());
        }
    }
}
