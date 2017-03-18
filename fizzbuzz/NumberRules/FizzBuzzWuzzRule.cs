using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class FizzBuzzWuzzRule : INumberRule
    {
        private int _number;

        public FizzBuzzWuzzRule(int number){
            _number = number;
        }

        public bool IsMatchRule(){
            return _number % 3 == 0 && _number % 5 == 0 && _number % 7 == 0;
        }

        public string GetResult(){
            return "FizzBuzzWuzz";
        }
    }
}
