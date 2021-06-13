namespace Chaiwatmat.Fizzbuzz
{
    public class WuzzRule : INumberRule
    {
        public int Priority => 7;

        public bool IsMatch(int number) => number % 7 == 0;

        public string GetResult() => "Wuzz";
    }
}