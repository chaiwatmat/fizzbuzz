using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class BuzzRule : INumberRule
    {
        private int _number;

        public BuzzRule(int number){
            _number = number;
        }

        public bool IsMatchRule(){
            return _number % 5 == 0;
        }

        public string GetResult(){
            return "Buzz";
        }
    }
}
