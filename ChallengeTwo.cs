using System.Collections.Generic;
using System.Linq;
using System;

namespace Challenges
{
    public static class ChallengeTwo
    {
        public static int FrequencyRepeatedFirst(this IEnumerable<int> inputs)
        {
            if (inputs == null || !inputs.Any())
            {
                throw new System.ArgumentNullException(nameof(inputs));
            }
            var result = 0;
            var i = 0;
            var results = new List<int>();
            var inputArr = inputs.ToArray();
            while(!results.Contains(result)){
                while(i < inputArr.Length && !results.Contains(result)){
                    results.Add(result);
                    result = result + inputArr[i];
                    //Console.WriteLine($"{i} {result} {inputArr[i]}");
                    i++;
                }
                i = 0;
            }
            return result;
        }
    }
}