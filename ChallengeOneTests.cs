using NUnit.Framework;
using System.Linq;

namespace Challenges
{
    public class ChallengeOneTests
    {
        [Test]
        public void Test1()
        {
            var input = new []{ "+1", "+1", "+1"} .Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().Frequency(), 3);
        }
        
        [Test]
        public void Test2()
        {
            var input = new []{ "+1", "+1", "-2"} .Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().Frequency(), 0);
        }
        
        [Test]
        public void Test3()
        {
            var input = new []{ "-1", "-2", "-3"} .Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().Frequency(), -6);
        }
        
        [Test]
        public void Test4()
        {
            var input = System.IO.File.ReadAllLines(@"..\..\..\inputChallengeOne").Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().Frequency(), 590);
        }
    }
}