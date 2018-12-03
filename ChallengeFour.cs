using System.Collections.Generic;
using System.Linq;
using System;

namespace Challenges
{
    public static class ChallengeFour
    {
        public static string CommonCharacters(this IEnumerable<string> input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }
            var inputList = input.ToList();
            var i = 0;
            var maxlength = input.Max(x => x.Length);
            var skipOnce = true;
            var result = "";
            while(i<maxlength){
                var indexes = inputList
                    .Select((x, index) => (x[i], index))
                    .GroupBy(g => g.Item1)
                    .Where(g => g.Count() > 1)
                    .SelectMany(g => g.Select(x=> x.Item2))
                    .ToArray();
                foreach(var index in indexes){
                    Console.WriteLine(index);
                }
                if(!indexes.Any()){
                    if(skipOnce) {
                        skipOnce = false;
                    } else
                    {
                        throw new Exception();
                    }
                }
                else {
                    result += inputList[indexes[0]][0];
                    Console.WriteLine(result);
                }
                inputList = inputList.Where((x,index) => indexes.Contains(index)).Select(x => new string(x.Skip(1).ToArray())).ToList();
                foreach(var inputitem in inputList){
                    Console.WriteLine(inputitem);
                }      
                i++;
                Console.WriteLine(i);
            }
            return result;

        }
    }
}