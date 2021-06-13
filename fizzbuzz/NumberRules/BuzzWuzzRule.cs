namespace Chaiwatmat.Fizzbuzz
{
    public class BuzzWuzzRule : INumberRule
    {
        public int Priority => 5 * 7;

        public bool IsMatch(int number) => number % 5 == 0 && number % 7 == 0;

        public string GetResult() => "BuzzWuzz";
    }
}