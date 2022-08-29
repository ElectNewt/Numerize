namespace Numerize.Test
{
    public class NumerizeTests
    {
        [Fact]
        public void TestSingleValue()
        {

            Numerize numerize = new Numerize();

            int result = numerize.Six();

            Assert.Equal(6, result);
        }

        [Fact]
        public void TestBasicNumbers()
        {

            Numerize numerize = new Numerize();

            long result = numerize.Three().Hundred().Fourty().Six();

            Assert.Equal(346, result);
        }

        [Fact]
        public void TestValueWithHundredsAndThousand()
        {

            Numerize numerize = new Numerize();

            long result = numerize.Three().Hundred().Thousand();

            Assert.Equal(300_000, result);

        }

        [Fact]
        public void TestSubcategoryOfNumbers()
        {
            Numerize numerize = new Numerize();

            long result = numerize.Three().Hundred().Eighty().Thousand();

            Assert.Equal(380_000, result);

        }

        [Fact]
        public void TestSubcategoryOfNumbersBiggerVersion()
        {
            Numerize numerize = new Numerize();

            long result = numerize.Three().Hundred().Eighty().Thousand().Fourty();

            Assert.Equal(380_040, result);

        }
        [Fact]
        public void TestSubcategoryOfNumbersExtraBigVersion()
        {
            Numerize numerize = new Numerize();

            long result = numerize.Three().Hundred().Eighty().Thousand().Fourty().Six();


            var number = Numerize.One.Billion();


            Assert.Equal(number, result);

            Assert.Equal(380_046, result);
        }

        
        

        [Fact]
        public void TestEvenBiggerNumber()
        {
            long result = Numerize.Fourty.Three().Billion()
                .Two().Hundred().Nine().Milion()
                .Four().Hundred().Twelve().Thousand()
                .Sixteen();
            Assert.Equal(43_209_412_016, result);
        }
    }
}