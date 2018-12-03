using System.Collections.Generic;
using System.Linq;
using System;

namespace Challenges
{
    public static class ChallengeOne
    {
        public static int Frequency(this IEnumerable<int> inputs)
        {
            if (inputs == null)
            {
                throw new System.ArgumentNullException(nameof(inputs));
            }
            return inputs.Aggregate(0, (acc, input) => acc + input);
        }
        public static IEnumerable<int> ParseList(this string input) {
            return input.Split(Environment.NewLine).Select(x=> Int32.Parse(x));
        }
    }
}