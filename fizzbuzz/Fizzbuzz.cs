using System;

namespace Chaiwatmat.Fizzbuzz
{
    public class Fizzbuzz
    {
        public string GetResult(int number){
            if(number % 3 == 0 && number % 5 == 0 && number % 7 == 0){
                return "FizzBuzzWuzz";
            }else if(number % 5 == 0 && number % 7 == 0){
                return "BuzzWuzz";
            }else if(number % 3 == 0 && number % 7 == 0){
                return "FizzWuzz";
            }else if(number % 3 == 0 && number % 5 == 0){
                return "FizzBuzz";
            }else if(number % 3 == 0){
                return "Fizz";
            }else if(number % 5 == 0){
                return "Buzz";
            }else if(number % 7 == 0){
                return "Wuzz";
            }
            return number.ToString();
        }
    }
}
