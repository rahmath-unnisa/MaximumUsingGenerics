using FindingMaxNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxCase1
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber max = new MaximumNumber();
            int actual = max.FindMaxInteger(8,3,5);
            Assert.AreEqual(actual, 8);
        }
    }
}