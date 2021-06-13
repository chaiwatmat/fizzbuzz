namespace Chaiwatmat.Fizzbuzz
{
    public class FizzRule : INumberRule
    {
        public int Priority => 3;

        public bool IsMatch(int number) => number % 3 == 0;

        public string GetResult() => "Fizz";
    }
}