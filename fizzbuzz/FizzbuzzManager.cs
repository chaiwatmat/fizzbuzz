using System;
using System.Collections.Generic;

namespace Chaiwatmat.Fizzbuzz
{
    public class FizzbuzzManager
    {
        public string GetResult(int number){
            var rules = new List<INumberRule>{
                new FizzBuzzWuzzRule(number),
                new BuzzWuzzRule(number),
                new FizzWuzzRule(number),
                new FizzBuzzRule(number),
                new WuzzRule(number),
                new BuzzRule(number),
                new FizzRule(number),
                new StringRule(number)
            };

            foreach(var rule in rules){
                if(rule.IsMatchRule()){
                    return rule.GetResult();
                }
            }

            return "";
        }
    }
}
