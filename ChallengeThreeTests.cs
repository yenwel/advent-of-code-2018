using NUnit.Framework;
using System.Linq;

namespace Challenges
{
    public class ChallengeThreeTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("abcdef".CheckSumBox(), (false,false));
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual("bababc".CheckSumBox(), (true,true));
        }
        
        [Test]
        public void Test3()
        {
            Assert.AreEqual("abbcde".CheckSumBox(), (true,false));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("abcccd".CheckSumBox(), (false,true));
        }
        
        [Test]
        public void Test5()
        {
            Assert.AreEqual("aabcdd".CheckSumBox(), (true,false));
        }
        
        [Test]
        public void Test6()
        {
            Assert.AreEqual("abcdee".CheckSumBox(), (true,false));
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual("ababab".CheckSumBox(), (false,true));
        }

        [Test]
        public void Test8()
        {
            Assert.AreEqual(new [] {"abcdef","bababc","abbcde","abcccd","aabcdd","abcdee","ababab"}.CheckSum(), 12);
        }

        [Test]
        public void Test9()
        {
            Assert.AreEqual(System.IO.File.ReadAllLines(@"..\..\..\inputChallengeThree").CheckSum(), 6448);
        }


    }
}