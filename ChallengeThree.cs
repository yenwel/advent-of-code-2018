using System.Collections.Generic;
using System.Linq;
using System;

namespace Challenges
{
    public static class ChallengeThree
    {
        public static (bool, bool) CheckSumBox(this string barcode)
        {
            if (barcode == null)
            {
                throw new System.ArgumentNullException(nameof(barcode));
            }
            var distinctCounts = 
                barcode.ToCharArray()
                .GroupBy(l => l)
                .Select(g =>(g.Key, g.Count()));
            foreach(var count in distinctCounts) Console.WriteLine($"{count.Item1},{count.Item2}");
            return (distinctCounts.Any(x=> x.Item2 == 2),distinctCounts.Any(x=> x.Item2 == 3));
        }

        public static int CheckSum(this IEnumerable<string> barcodes)
        {
            var sumTwoAndThrees = barcodes.Select(x => x.CheckSumBox()).Aggregate(Tuple.Create(0,0), (twosAndThrees,areTwoAndThrees) => Tuple.Create(areTwoAndThrees.Item1?twosAndThrees.Item1+1:twosAndThrees.Item1, areTwoAndThrees.Item2?twosAndThrees.Item2+1:twosAndThrees.Item2));
            Console.WriteLine($"{sumTwoAndThrees.Item1} {sumTwoAndThrees.Item2}");
            return sumTwoAndThrees.Item1 * sumTwoAndThrees.Item2;
        }
    }
}