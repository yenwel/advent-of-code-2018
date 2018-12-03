using NUnit.Framework;
using System.Linq;

namespace Challenges
{
    public class ChallengeTwoTests
    {
        [Test]
        public void Test1()
        {
            var input = new []{ "+1", "-1"} .Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().FrequencyRepeatedFirst(), 0);
        }
        
        [Test]
        public void Test2()
        {
            var input = new []{ "+3", "+3", "+4", "-2", "-4"} .Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().FrequencyRepeatedFirst(), 10);
        }
        
        [Test]
        public void Test3()
        {
            var input = new []{"-6", "+3", "+8", "+5", "-6"} .Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().FrequencyRepeatedFirst(), 5);
        }

        [Test]
        public void Test4()
        {
            var input = new []{"+7", "+7", "-2", "-7", "-4"} .Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().FrequencyRepeatedFirst(), 14);
        }
        
        [Test]
        public void Test5()
        {
            var input = System.IO.File.ReadAllLines(@"..\..\..\inputChallengeOne").Aggregate((one,  two ) => $"{one}{System.Environment.NewLine}{two}");
            Assert.AreEqual(input.ParseList().FrequencyRepeatedFirst(), 83445);
        }
    }
}