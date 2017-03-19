using System;

namespace Chaiwatmat.Fizzbuzz
{
    public interface INumberRule
    {
        bool IsMatchRule();
        string GetResult();
    }
}
