namespace Chaiwatmat.Fizzbuzz
{
    public class FizzWuzzRule : INumberRule
    {
        public int Priority => 3 * 7;

        public bool IsMatch(int number) => number % 3 == 0 && number % 7 == 0;

        public string GetResult() => "FizzWuzz";
    }
}