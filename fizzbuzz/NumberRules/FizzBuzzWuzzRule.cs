namespace Chaiwatmat.Fizzbuzz
{
    public class FizzBuzzWuzzRule : INumberRule
    {
        public int Priority => 3 * 5 * 7;

        public bool IsMatch(int number) => number % 3 == 0 && number % 5 == 0 && number % 7 == 0;

        public string GetResult() => "FizzBuzzWuzz";
    }
}