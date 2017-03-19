using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class FizzWuzzRule : INumberRule
    {
        private int _number;

        public FizzWuzzRule(int number){
            _number = number;
        }

        public bool IsMatchRule(){
            return _number % 3 == 0 && _number % 7 == 0;
        }

        public string GetResult(){
            return "FizzWuzz";
        }
    }
}
