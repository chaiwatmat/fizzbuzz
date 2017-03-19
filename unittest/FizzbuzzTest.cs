using System;
using Xunit;
using Chaiwatmat.Fizzbuzz;

namespace Chaiwatmat.Fizzbuzz.Test
{
    public class FizzbuzzTest
    {
        private FizzbuzzManager _fizzbuzz;

        public FizzbuzzTest(){
            _fizzbuzz = new FizzbuzzManager();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void SendNumber_ShouldReturnStringNumber(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        public void SendNumberDivideBy3_ShouldReturnStringFizz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        public void SendNumberDivideBy5_ShouldReturnStringBuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        public void SendNumberDivideBy15_ShouldReturnStringFizzBuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(7, "Wuzz")]
        [InlineData(14, "Wuzz")]
        public void SendNumberDivideBy7_ShouldReturnStringWuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(21, "FizzWuzz")]
        [InlineData(42, "FizzWuzz")]
        public void SendNumberDivideBy21_ShouldReturnStringFizzWuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(35, "BuzzWuzz")]
        [InlineData(70, "BuzzWuzz")]
        public void SendNumberDivideBy35_ShouldReturnStringBuzzWuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(105, "FizzBuzzWuzz")]
        [InlineData(210, "FizzBuzzWuzz")]
        public void SendNumberDivideBy105_ShouldReturnStringFizzBuzzWuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.Equal(expected, result);
        }
    }
}
