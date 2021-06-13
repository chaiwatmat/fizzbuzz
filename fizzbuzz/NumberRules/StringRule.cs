namespace Chaiwatmat.Fizzbuzz
{
    public class StringRule : INumberRule
    {
        private int _number;

        public int Priority => 1;

        public bool IsMatch(int number)
        {
            _number = number;

            return true;
        }

        public string GetResult() => _number.ToString();
    }
}