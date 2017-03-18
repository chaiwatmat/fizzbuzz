using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class WuzzRule : INumberRule
    {
        private int _number;

        public WuzzRule(int number){
            _number = number;
        }

        public bool IsMatchRule(){
            return _number % 7 == 0;
        }

        public string GetResult(){
            return "Wuzz";
        }
    }
}
