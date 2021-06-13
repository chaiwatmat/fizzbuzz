using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Chaiwatmat.Fizzbuzz
{
    public class FizzbuzzManager
    {
        public string GetResult(int number)
        {
            var rules = GetRules();

            foreach (var rule in rules)
            {
                if (!rule.IsMatch(number)) continue;

                return rule.GetResult();
            }

            return "";
        }

        private static IEnumerable<INumberRule> GetRules()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(INumberRule).IsAssignableFrom(x) && x.IsClass)
                .Select(x => (INumberRule)Activator.CreateInstance(x))
                .OrderByDescending(x => x.Priority);
        }
    }
}