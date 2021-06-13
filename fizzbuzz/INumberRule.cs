namespace Chaiwatmat.Fizzbuzz
{
    public interface INumberRule
    {
        int Priority { get; }

        bool IsMatch(int number);

        string GetResult();
    }
}