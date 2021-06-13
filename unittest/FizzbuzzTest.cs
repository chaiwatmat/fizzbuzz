using Xunit;

namespace Chaiwatmat.Fizzbuzz.Test
{
    public class FizzbuzzTest
    {
        private FizzbuzzManager _fizzbuzz;

        public FizzbuzzTest()
        {
            _fizzbuzz = new FizzbuzzManager();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void SendNumber_ShouldReturnStringNumber(int number, string expected)
        {
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "divide by 3,5,7")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(7, "Wuzz")]
        public void Send_1_MatchedNumber_ShouldReturnMatchedText(int number, string expected)
        {
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3 * 5, "FizzBuzz")]
        [InlineData(3 * 7, "FizzWuzz")]
        [InlineData(5 * 7, "BuzzWuzz")]
        public void Send_2_MatchedNumber_ShouldReturnMatchedText(int number, string expected)
        {
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3 * 5 * 7, "FizzBuzzWuzz")]
        public void Send_3_MatchedNumber_ShouldReturnMatchedText(int number, string expected)
        {
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }
    }
}