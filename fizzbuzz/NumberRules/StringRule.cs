using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class StringRule : INumberRule
    {
        private int _number;

        public StringRule(int number){
            _number = number;
        }

        public bool IsMatchRule(){
            return true;
        }

        public string GetResult(){
            return _number.ToString();
        }
    }
}
