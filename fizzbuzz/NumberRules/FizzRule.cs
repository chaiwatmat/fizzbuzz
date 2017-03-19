using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class FizzRule : INumberRule
    {
        private int _number;

        public FizzRule(int number){
            _number = number;
        }

        public bool IsMatchRule(){
            return _number % 3 == 0;
        }

        public string GetResult(){
            return "Fizz";
        }
    }
}
