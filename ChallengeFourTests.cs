using NUnit.Framework;
using System.Linq;

namespace Challenges
{
    public class ChallengeFourTests
    {
        [Test]
        public void Test1()
        {
            var input = new [] {"abcde","fghij","klmno","pqrst","fguij","axcye","wvxyz"};
            Assert.AreEqual(input.CommonCharacters(), "fgij");
        }

        /* [Test]
        public void Test9()
        {
            Assert.AreEqual(System.IO.File.ReadAllLines(@"..\..\..\inputChallengeThree").CheckSum(), 6448);
        }*/


    }
}