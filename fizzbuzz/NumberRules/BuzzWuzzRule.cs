using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class BuzzWuzzRule : INumberRule
    {
        private int _number;

        public BuzzWuzzRule(int number){
            _number = number;
        }

        public bool IsMatchRule(){
            return _number % 5 == 0 && _number % 7 == 0;
        }

        public string GetResult(){
            return "BuzzWuzz";
        }
    }
}
