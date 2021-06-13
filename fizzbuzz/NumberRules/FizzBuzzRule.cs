namespace Chaiwatmat.Fizzbuzz
{
    public class FizzBuzzRule : INumberRule
    {
        public int Priority => 3 * 5;

        public bool IsMatch(int number) => number % 3 == 0 && number % 5 == 0;

        public string GetResult() => "FizzBuzz";
    }
}