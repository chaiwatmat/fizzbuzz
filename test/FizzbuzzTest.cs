using System;
using NUnit.Framework;
using Chaiwatmat.Fizzbuzz;

namespace Chaiwatmat.Fizzbuzz.Test
{
    [TestFixture]
    public class FizzbuzzTest
    {
        private FizzbuzzManager _fizzbuzz;

        public FizzbuzzTest(){
            _fizzbuzz = new FizzbuzzManager();
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void SendNumber_ShouldReturnStringNumber(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        public void SendNumberDivideBy3_ShouldReturnStringFizz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        public void SendNumberDivideBy5_ShouldReturnStringBuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void SendNumberDivideBy15_ShouldReturnStringFizzBuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(7, "Wuzz")]
        [TestCase(14, "Wuzz")]
        public void SendNumberDivideBy7_ShouldReturnStringWuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(21, "FizzWuzz")]
        [TestCase(42, "FizzWuzz")]
        public void SendNumberDivideBy21_ShouldReturnStringFizzWuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(35, "BuzzWuzz")]
        [TestCase(70, "BuzzWuzz")]
        public void SendNumberDivideBy35_ShouldReturnStringBuzzWuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(105, "FizzBuzzWuzz")]
        [TestCase(210, "FizzBuzzWuzz")]
        public void SendNumberDivideBy105_ShouldReturnStringFizzBuzzWuzz(int number, string expected){
            var result = _fizzbuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }
    }
}
