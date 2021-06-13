namespace Chaiwatmat.Fizzbuzz
{
    public class BuzzRule : INumberRule
    {
        public int Priority => 5;

        public bool IsMatch(int number) => number % 5 == 0;

        public string GetResult() => "Buzz";
    }
}