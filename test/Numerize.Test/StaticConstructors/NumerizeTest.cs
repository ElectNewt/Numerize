namespace Numerize.Test.StaticConstructors
{
    public class NumerizeTest
    {
        [Fact]
        public void TestSingleDigit()
        {
            long result = Numerize.Five;
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestMultipleDigits()
        {
            long result = Numerize.Eighteen.Thousand().Three().Hundred().Twenty().Seven();
            Assert.Equal(18_327, result);
        }
    }
}
