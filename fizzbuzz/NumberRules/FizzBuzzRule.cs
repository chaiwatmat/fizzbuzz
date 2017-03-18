using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class FizzBuzzRule : INumberRule
    {
        private int _number;

        public FizzBuzzRule(int number){
            _number = number;
        }

        public bool IsMatchRule(){
            return _number % 3 == 0 && _number % 5 == 0;
        }

        public string GetResult(){
            return "FizzBuzz";
        }
    }
}
